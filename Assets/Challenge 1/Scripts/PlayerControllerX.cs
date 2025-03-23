using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 1;
    public float rotationSpeed;
    public float verticalInput;
    public float constraint;
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
        constraint = 0.4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Horizontal"); 
        rotationSpeed = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * verticalInput * constraint);

        // tilt the plane up/down based on up/down arrow keys
        if (rotationSpeed > 0)
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * rotationSpeed*10);

        }
        else
        {
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * rotationSpeed*10);

        }
    }
}
