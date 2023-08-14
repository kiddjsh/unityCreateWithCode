using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // public float speed = 10.0f;  // 4.1 | Added speed variable
    public float speed = 5.0f;  // 5.1 | Updated speed variable
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        // transform.Translate(Vector3.back * speed);
        // transform.Translate(Vector3.forward * speed);  // 3.1 | Updated Vector3.back to Vector3.forward 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  // 4.1 | Added Time.deltaTime to multiply a value changing it from 1x/frame to 1x/second 

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);  // 5.1 | Added to calculation to multiply verticalInput in Rotate 
    }
}
