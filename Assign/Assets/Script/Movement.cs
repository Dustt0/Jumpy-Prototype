using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float sSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        //{
        //    rb.AddForce(0, sSpeed, 0);
        //}

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            Vector3 touchPosition = Input.GetTouch(0).position;

            double halfScreen = Screen.width / 2;




            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {
                rb.AddForce(0, sSpeed, 0);
            }

            else if (touchPosition.x > halfScreen)
            {
                rb.AddForce(0, sSpeed, 0);
            }

        }
    }
}

    

