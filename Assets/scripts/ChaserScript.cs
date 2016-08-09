using UnityEngine;
using System.Collections;

public class ChaserScript : CommonEnemyController {

	void Update ()
    {
        //This is common for all enemies.
        LookAtTarget();
        CalculateDistanceFromTarget();
        //This is not.
        MoveToTarget();
	}

    void MoveToTarget()
    {
        if (distanceFromTarget >= catchZone)
            transform.position += (transform.forward * speed) * Time.deltaTime;
    }
}
