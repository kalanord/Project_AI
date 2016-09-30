using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float lifeSpan; //Amount of Seconds the bullet is alive

    private Rigidbody rb;
    private float timeOfDeath; //Used to calculate when the bullet should die
    private Vector3 spawnPosition; //Used to reset the bullet to its initial position after death
    private Transform parent;

    void Start()
    {
        parent = transform.parent.transform;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

        //This saves the bullet initial position so it can be resetted when disabled.
        //spawnPosition = transform.position;
    }

    void Update()
    {
        if (Time.time >= timeOfDeath)
            gameObject.SetActive(false);
    }

    void OnEnable() //Called when the bullet is fired.
    {
        spawnPosition.Set(parent.position.x, 0.0f, parent.position.z);
        timeOfDeath = Time.time + lifeSpan;
    }
}