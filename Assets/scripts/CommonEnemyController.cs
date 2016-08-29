using UnityEngine;
using System.Collections;

public abstract class CommonEnemyController : MonoBehaviour {

    private Vector3 direction;

    [SerializeField]
    protected int speed;

    void OnTriggerStay(Collider target) //This works as the Field of View for the Enemy, 
                                        //when the Player enters in it, the Enemy reacts to it.
    {
        if (target.gameObject.CompareTag("Player"))
        {
            LookAtTarget(target.transform);
            //This method is used in every Enemy script to modify their behaviour when they are aware of the player
            SpecificBehaviour();
        }
    }

    protected void LookAtTarget(Transform target)
    {
        direction = target.position - transform.position;
        transform.forward = direction.normalized;
    }

    protected abstract void SpecificBehaviour(); 
}