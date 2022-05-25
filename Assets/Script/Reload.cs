using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))

        {
            Lifeamount.Point = 0;
            Lifeamount.Life = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {

            SceneManager.LoadScene(0);
        }

    }
}
