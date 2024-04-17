using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public int ballForce;

    //If the ball hits these circles it will bounce off faster
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            rb.AddForce(Vector2.up * ballForce);
        }
    }
}
