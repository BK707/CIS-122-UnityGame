using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody kd;
    //reduce both forces or edit in unity as a vairable*****************
    public float ForwardForce = 1000f;
    public float sidewaysForce = 200f;
    public float upwardForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force *****vary forward force with timer so gets faster as timer goes on********************
        //could give same function to camera and hve game end when player.pos < camera.pos since player collision but not camera***************
        
        
        kd.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            kd.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            kd.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            kd.AddForce(0, upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


    }
}
