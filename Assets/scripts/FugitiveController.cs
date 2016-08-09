using UnityEngine;
using System.Collections;

public class FugitiveController : CommonEnemyController {

	void Update ()
    {
        //This is common for all enemies.
        LookAtTarget();
        CalculateDistanceFromTarget();
        //This is not.
        MoveAwayFromTarget();
	}

    void MoveAwayFromTarget()
    {
        if (distanceFromTarget < catchZone)
            transform.position -= (transform.forward * speed) * Time.deltaTime;
    }
}
