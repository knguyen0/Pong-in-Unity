using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)           //unity calls automatically when bouncySurface collides
    {                                                                 //collision has data of how 2 objects collided and angle
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)                                                    //check if valid ball object. if null then it wasn't ball that collided
        {
            Vector2 normal = collision.GetContact(0).normal;                     //vector pointing away from field when ball hits wall
            ball.AddForce(-normal * this.bounceStrength);                   //add speed in opposite direction with negative. bouncestrength is manually added through unity
        }                                                               //getContact point of collision against wall and store it in normal
    }
}
