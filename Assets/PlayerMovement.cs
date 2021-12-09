//written by sam sunnarborg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody kd;
    //reduce both forces or edit in unity as a vairable*****************
    public float ForwardForce = 100f;
    public float sidewaysForce = 200f;
    public float upwardForce = 10f;

    //creates a timer object to refer to in order to change speed with timer
    public RunningScore runningScore;
    
    //allows the forward force to change with the timer
    public float multiplier;


    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force *****vary forward force with timer so gets faster as timer goes on********************
        //ForwardForce = Mathf.RoundToInt(1 + (ForwardForce * runningScore.score * multiplier));
        
        //constant forward force option
        kd.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.VelocityChange);


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
            kd.AddForce(0, upwardForce * 0.025f, 0, ForceMode.VelocityChange);
        }

    }
}
