using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    public Vector3 jump;
    public float jumpForce = 4.0f;

    public bool isGrounded;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Platform")
        {
            isGrounded = true;
        }
    }

        // Update is called once per frame
        void Update () {
	    if(Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }	
	}
}
