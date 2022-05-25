using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_disableitem : MonoBehaviour
{
    public GameObject ToEnable;
    public GameObject Todisable1;
    public GameObject ToDisable;
    public GameObject remove;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Todisable1.SetActive(false);
            ToEnable.SetActive(true);
            ToDisable.SetActive(false);
            Destroy(remove);
        }
    }


}
