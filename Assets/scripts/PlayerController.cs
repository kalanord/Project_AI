using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float moveHorizontal; 
    private float moveVertical;

    private Vector3 movement; 

    private Rigidbody rb; 

    public float speed; 
    
   	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        movement = Vector3.zero;

        moveHorizontal = 0;
        moveVertical = 0;
	}
    
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {

        moveHorizontal = Input.GetAxis("Horizontal"); 
        moveVertical = Input.GetAxis("Vertical");

        movement.Set(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
