using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigMovement : MonoBehaviour
{

    private Rigidbody rb;
    public bool isMove;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        //if(isMove == true)
        //{
            Move();
        //}
    }

    private void Move()
    {
        rb.AddForce(0, -0.01f, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "A")
        {
            isMove = true;
        }

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        //{

        //    Vector3 touchPosition = Input.GetTouch(0).position;

        //    double halfScreen = Screen.width / 2;




        //    //Check if it is left or right?
        //    if (touchPosition.x < halfScreen)
        //    {
        //        isMove = false;
        //    }

        //    else if (touchPosition.x > halfScreen)
        //    {
        //        isMove = false;
        //    }

        //    else
        //        isMove = true;

        //}
    }
}
