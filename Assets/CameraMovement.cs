using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;



    // Update is called once per frame
    void FixedUpdate () {
        // Debug.Log(player.position);
        Vector3 desiredPos = player.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPos ;

        transform.LookAt(player);
	}
}
