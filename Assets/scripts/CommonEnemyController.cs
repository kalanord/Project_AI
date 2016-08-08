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

    void Start()
    {
        if (target == null) //This automatically looks for the "player" tag and assigns it as the target, assuming that's the target
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    protected void LookAtTarget()
    {
        direction = target.position - transform.position;
        transform.forward = direction.normalized;
    }
}