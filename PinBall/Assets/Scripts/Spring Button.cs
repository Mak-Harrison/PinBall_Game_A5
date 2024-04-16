using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class SpringButton : MonoBehaviour

{
    public float speed = 5;
    public Rigidbody2D rb2d;
    public float strength =80f;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Force();
    }

    void Move()
    {
        bool isPressed = Input.GetKey(KeyCode.Space);
        if (isPressed)
        {
            Vector2 force = Vector2.down * strength;
            rb2d.AddForce(force);
        }
    }

    void Force()
    {
        
    }
}
