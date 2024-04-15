using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringButton : MonoBehaviour

{
    public int Points;
    public GameObject Spring;
    public float PowerPerSecond;
    public int SpringStatus;
    public float Power;
    public bool Collider;
    void Start()
    {
        // When Game Starts reset these values.
        SpringStatus = 1;
        Power = 0f;
        Points = 0;
        Spring = GameObject.Find("Spring");
        Collider = true;
    }

    void SpringGettingCompressed()
    {
        if (transform.position.x > -2.3)
        {
            transform.position = new Vector3(transform.position.x - 0.05f * Time.deltaTime, transform.position.y, transform.position.z);
            Power += PowerPerSecond * Time.deltaTime;

        }
    }

    void SpringReleased()
    {
        if (transform.position.x <= -1.9)
        {
            transform.position = new Vector3(transform.position.x + Power * Time.deltaTime, transform.position.y, transform.position.z);
            SpringStatus = 2;
            Collider = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If spring is in out position & user holds down the Space Button, Start Compressing the spring.
        if (SpringStatus == 1 && Input.GetKey(KeyCode.Space))
        {
            SpringGettingCompressed();
        }

        if (Input.GetKeyUp(KeyCode.Space) && SpringStatus == 1)
        {
            SpringReleased();
        }
    }
}
