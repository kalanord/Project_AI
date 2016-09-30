using UnityEngine;
using System.Collections;

public class EnemyWeaponController : ObjectPoolController {

    [SerializeField]
    private float fireRate;

    private float nextFire;

    protected override void OtherInitializations()
    {
        nextFire = 0;
    }

    void OnTriggerStay(Collider e)
    {
        if (e.gameObject.tag.Equals("Player") && Time.time > nextFire)
        {
            ObjectRequest();
            nextFire = Time.time + fireRate;
        }
    }
}
