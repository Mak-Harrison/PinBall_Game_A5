using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    public Rigidbody2D lf;

    void OnCollisionEnter(Collision2D Collision)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.GetComponent(HingeJoint2D).useMotor = true;
        }
    }
   
    //void 
    //Vector3 offset = Vector3.zero;

    //bool isHoldingLeft = Input.GetKeyDown(KeyCode.LeftArrow);

    //if (isHoldingLeft)
    //{

    //}
    //bool isHoldingRight = Input.GetKeyDown(KeyCode.RightArrow);
}
