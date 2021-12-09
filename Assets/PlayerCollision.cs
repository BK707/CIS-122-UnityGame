//written by sam sunnarborg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    //public PlayerMovement movement;
    //public RunningScore runningScore;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
            RunningScore.instance.RemovePoints();
        }
    }


}
