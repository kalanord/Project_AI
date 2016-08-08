using UnityEngine;
using System.Collections;

public class FugitiveController : CommonEnemyController {

	void Update ()
    {
        LookAtTarget();
        MoveAwayFromTarget();
	}

    void MoveAwayFromTarget()
    {
        float distanceFromTarget = transform.position.magnitude - target.position.magnitude;
        
        if (distanceFromTarget < catchZone)
            transform.position -= (transform.forward * speed);
    }
}
