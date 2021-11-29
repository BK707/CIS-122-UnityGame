using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

   
  
    public PlayerMovement movement;

     void OnCollisionEnter(Collision collisionInfo)
    {
        //Currently stopd motion of box, don't stop it just reduce score/timer and player can keep going****************
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
