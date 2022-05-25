using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gameover : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void TryAgain()
    {
        Lifeamount.Point = 0;
        Lifeamount.Life = 3;
        SceneManager.LoadScene("Level 1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Startscreen");
    }

    public void Training()
    {
        SceneManager.LoadScene("Training ground");
    }



}
