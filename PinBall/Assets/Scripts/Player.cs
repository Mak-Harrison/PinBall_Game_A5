using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = Vector3.zero;

        bool isHoldingLeft = Input.GetKeyDown(KeyCode.LeftArrow);
        bool isHoldingRight = Input.GetKeyDown(KeyCode.RightArrow);


    }
}
