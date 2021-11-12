using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody kd;
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        kd.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            kd.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            kd.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


    }
}
