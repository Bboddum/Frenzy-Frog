using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int NextLevel;
    public float TimeUntilNextLevel;
    [SerializeField] private AudioSource Nextlevel;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            
            Nextlevel.Play();
            StartCoroutine(Waitandchangelevel());
            
        }
    }
    IEnumerator Waitandchangelevel()
    {
        yield return new WaitForSeconds(TimeUntilNextLevel);
        SceneManager.LoadScene(NextLevel);
    }
}
