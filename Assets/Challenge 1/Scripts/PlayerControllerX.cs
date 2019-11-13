using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float StartingSpeed;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public GameObject Prop;
    public float PropSpeed;
    public float SpeedModifier;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // modify the speed
        speed = StartingSpeed;
        speed = speed + (horizontalInput*SpeedModifier);

        // get the user's 'Boost' input
        horizontalInput = Input.GetAxis("Fire1");

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a controlled speed 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);

        // rotate the prop
        Prop.transform.Rotate(Vector3.forward * PropSpeed * Time.deltaTime);
    }
}
