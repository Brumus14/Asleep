using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundChange : MonoBehaviour 
{
    void Update()
    {
        if(transform.position.x >= 9 && SceneManager.GetActiveScene().name == "outside")
        {
            SceneManager.LoadScene("outsidePathway");
        }
        if (transform.position.x <= -9 && SceneManager.GetActiveScene().name == "outsidePathway")
        {
            SceneManager.LoadScene("outside");
        }
    }
}
