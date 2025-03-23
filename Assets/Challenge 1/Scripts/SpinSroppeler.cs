using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSroppeler : PlayerControllerX
{
    public GameObject Center;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (verticalInput != 0)
        {
            transform.RotateAround(Center.transform.position,Vector3.forward, 200 * Time.deltaTime);

        }
        else
        {
            transform.RotateAround(Center.transform.position, Vector3.back, 200 * Time.deltaTime);
        }
    }
}
