using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 35;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We get the axis
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // We move the vehicle forward
        transform.Translate(Vector3.forward* Time.deltaTime*speed * forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
