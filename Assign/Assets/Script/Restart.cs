using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject ca;

    //private void Start()
    //{
    //    Time.timeScale = 1;
    //}
    public void _Restart()
    {
        SceneManager.LoadScene("GameScene");
        ca.SetActive(false);
    }
}
