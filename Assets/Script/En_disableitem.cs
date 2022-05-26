using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_disableitem : MonoBehaviour
{
    public GameObject ToEnable1;
    public GameObject ToEnable;
    public GameObject Todisable1;
    public GameObject ToDisable;
    public GameObject remove;
    public GameObject remove1;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Transitpoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Todisable1.SetActive(false);
            ToEnable.SetActive(true);
            ToEnable1.SetActive(true);
            ToDisable.SetActive(false);
            Destroy(remove);
            Destroy(remove1);
            Player.transform.position = Transitpoint.transform.position;
        }
    }


}
