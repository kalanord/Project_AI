using UnityEngine;
using System.Collections;

public class FugitiveController : CommonEnemyController {

    protected override void SpecificBehaviour(Transform target)
    {
        MoveAwayFromTarget();
    }

    void MoveAwayFromTarget()
    {
        transform.position -= (transform.forward * speed) * Time.deltaTime;
    }
}
