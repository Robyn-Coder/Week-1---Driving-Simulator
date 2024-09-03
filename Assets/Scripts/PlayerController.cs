using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   //Speed variables
   //private float speed = 15f; this was to test for auto movement of the car
   //private float turnSpeed = 50f;

   //Input declarations
   private float horizontalInput;
   private float forwardInput;

    void Update()
    {
        //Back and Forward direction movement
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

        //Left and Right direction movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);

    }
}
