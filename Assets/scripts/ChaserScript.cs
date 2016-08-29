using UnityEngine;
using System.Collections;

public class ChaserScript : CommonEnemyController {

    protected override void SpecificBehaviour()
    {
        //MoveToTarget(); Needs work, I need to specify when to stop. I think I can't use triggers again. :(
    }

    void MoveToTarget()
    {
        transform.position += (transform.forward * speed) * Time.deltaTime;
    }
}
