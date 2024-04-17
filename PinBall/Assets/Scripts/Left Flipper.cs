using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true) on(); else off();
    }
    void on()
    {
        
    }

    void off()
    {
        
    }
    void Start()
    {
        off();
    }
    //void 
    //Vector3 offset = Vector3.zero;

    //bool isHoldingLeft = Input.GetKeyDown(KeyCode.LeftArrow);

    //if (isHoldingLeft)
    //{

    //}
    //bool isHoldingRight = Input.GetKeyDown(KeyCode.RightArrow);
}
