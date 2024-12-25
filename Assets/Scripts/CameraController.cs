using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset = new Vector3(5, 5, -11);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {        
        //offset the position of the camera 
        transform.position = Player.transform.position + offset;

    }
}
