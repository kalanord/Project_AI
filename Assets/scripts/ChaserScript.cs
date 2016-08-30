using UnityEngine;
using System.Collections;

public class ChaserScript : CommonEnemyController {

    [SerializeField]
    private float stopZone;

    protected override void SpecificBehaviour(Transform target)
    {
        MoveToTarget(target);
    }

    void MoveToTarget(Transform target)
    {
        if (Vector3.Distance(target.position, transform.position) >= stopZone)
            transform.position += (transform.forward * speed) * Time.deltaTime;
    }
}
