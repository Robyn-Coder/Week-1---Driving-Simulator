using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    public float speed = 30f; // Forward speed
    public float rotationSpeed = 50f; // Rotation speed
    public float tiltAngle = 30f; // Maximum tilt angle

    void Update()
    {
        // Automatically move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Get input for vertical movement (up/down)
        float verticalInput = Input.GetAxis("Vertical");

        // Get input for horizontal movement (left/right)
        //float horizontalInput = Input.GetAxis("Horizontal"); Not needed

        // Move the plane up/down
        transform.Translate(Vector3.up * verticalInput * rotationSpeed * Time.deltaTime);

        // Tilt the plane based on vertical input
        float tilt = -verticalInput * tiltAngle;
        transform.rotation = Quaternion.Euler(tilt, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        // Rotate the plane left/right
        //transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); Not needed
    }
}
