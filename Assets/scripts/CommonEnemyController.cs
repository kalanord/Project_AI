using UnityEngine;
using System.Collections;

public class CommonEnemyController : MonoBehaviour {

    [SerializeField]
    protected Transform target;
    private Vector3 direction;

    [SerializeField]
    protected int speed;
    [SerializeField]
    protected float catchZone;
    protected float distanceFromTarget;

    void Start()
    {
        //This automatically looks for the "player" tag and assigns it as the target, assuming that's the target
        if (target == null) 
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    protected void LookAtTarget()
    {
        direction = target.position - transform.position;
        transform.forward = direction.normalized;
    }

    protected void CalculateDistanceFromTarget()
    {
        distanceFromTarget = Vector3.Distance(target.position, transform.position);
    }
}