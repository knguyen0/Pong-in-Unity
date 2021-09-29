using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompPaddle : Paddle
{

    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)                                //if ball is moving towards paddle
        {
            if (this.ball.position.y > this.transform.position.y)       //if ball is higher than paddle
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else                        //if ball is moving away from paddle, idle at centre
        {
            if (this.transform.position.y > 0.0f)           //if paddle is above centre
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
