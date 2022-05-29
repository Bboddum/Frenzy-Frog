using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{

    [SerializeField] private GameObject removeItem;
    [SerializeField] private GameObject uiObject;
    [SerializeField] private Text Pointtext;
    void Start()
    {
        uiObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            Lifeamount.Point = 0;
            Lifeamount.Life = 3;
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        Destroy(uiObject);
        Destroy(gameObject);
        Destroy(removeItem);
        Pointtext.text = "Point:" + Lifeamount.Point;
    }

}
