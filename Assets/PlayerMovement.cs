using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float movementForce = 500f;



    // Use this for initialization
    void Start () {
        // rb.AddForce(0, 200, 500);
		
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("a")) {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movementForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movementForce * Time.deltaTime);
        }

        float accX = Input.acceleration.x;
        Debug.Log(accX);
        /*
        if(accX < 0.3)
        {
            MoveLeft();
        } else if (accX > 0.3)
        {
            MoveRight();
        } else
        {
           
        } */
        
        
        rb.AddForce(accX*movementForce, 0, 0);
        
    }
    void MoveRight()
    {
        rb.AddForce(movementForce * Time.deltaTime, 0, 0);
    }
    void MoveLeft()
    {
        rb.AddForce(-movementForce * Time.deltaTime, 0, 0);
    }

}
