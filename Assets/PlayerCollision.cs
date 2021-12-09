//written by sam sunnarborg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    //public RunningScore runningScore;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //if player collides with an obstacle, take points away
        if (collisionInfo.collider.tag == "Obstacle")
        {
            
            RunningScore.instance.RemovePoints();
        }
        //if player collides with finish line...
        if(collisionInfo.collider.tag == "FinishLine")
        {
            movement.enabled = false;
            /*
            if(score >= 50)
            {

            }
            else
            {

            */
        }

    }


}
