using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jSpeed;
    public bool isGround = true;
    public Transform ground;
    public float groundDis = 0.1f;
    public LayerMask gr;

    void Update()
    {
        isGround = Physics.CheckSphere(ground.position, groundDis, gr, QueryTriggerInteraction.Ignore);
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    if (isGround)
        //    {
        //        transform.position += new Vector3(1, jSpeed * Time.deltaTime, 0);

        //        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        //    }

        //}

        //if (Input.GetKeyDown(KeyCode.A))
        //{

        //    if (isGround)
        //    {
        //        transform.position += new Vector3(0, jSpeed * Time.deltaTime, -1);

        //        GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);
        //    }
        //}

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            Vector3 touchPosition = Input.GetTouch(0).position;

            double halfScreen = Screen.width / 2.0;




            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {

                if (isGround)
                {
                    transform.position -= new Vector3(0, jSpeed * Time.deltaTime, 1);

                    GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);
                }
            }

            else if (touchPosition.x > halfScreen)
            {
                if (isGround)
                {
                    transform.position += new Vector3(1, jSpeed * Time.deltaTime, 0);

                    GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
                }
            }

        }
    }
}

