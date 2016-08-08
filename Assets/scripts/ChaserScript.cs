using UnityEngine;
using System.Collections;

public class ChaserScript : CommonEnemyController {

	void Update ()
    {
        LookAtTarget();
        MoveToTarget();
	}

    void MoveToTarget()
    {
        float distanceFromTarget = transform.position.magnitude - target.position.magnitude;

        if (distanceFromTarget > catchZone)
            transform.position += (transform.forward * speed) * Time.deltaTime;
    }
}
