using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset = new Vector3(0, 3, -6);
    Vector3 FirstPersonOffset = new Vector3(1, 1, 1);
    private bool SwitchCameraPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        SwitchCameraPosition = Input.GetKey("x");
        //offset the position of the camera 
        transform.position = Player.transform.position + offset;

    }
}
