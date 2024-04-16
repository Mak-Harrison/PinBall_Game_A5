using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class SpringButton : MonoBehaviour

{
    public float speed = 5;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 offset = Vector3.zero;

        bool isPressed = Input.GetKey(KeyCode.Space);

        if (isPressed)
        {
            offset.y -= speed;
        }

        transform.position = offset * Time.deltaTime;
    }
}
