using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    public GameObject c;
    
    private void Start()
    {
        Time.timeScale = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            c.SetActive(true);
            
            Time.timeScale = 0;
        }
    }
}
