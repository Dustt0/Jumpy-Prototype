using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float mSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D)))
        //{
        //    transform.position -= new Vector3(0, mSpeed * Time.deltaTime, 0);
        //}



        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            Vector3 touchPosition = Input.GetTouch(0).position;

            double halfScreen = Screen.width / 2;




            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {
                transform.position += new Vector3(0, mSpeed * Time.deltaTime, 0);
            }

            else if (touchPosition.x > halfScreen)
            {
                transform.position += new Vector3(0, mSpeed * Time.deltaTime, 0);
            }

        }
    }
}
