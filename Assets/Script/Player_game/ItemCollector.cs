using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource collect;

    [SerializeField] private Text Pointtext;
    [SerializeField] private Text Lifetext;
    // Start is called before the first frame update
    void Start()
    {
        Pointtext.text = "Point:" + Lifeamount.Point;
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            sound();
            Lifeamount.Point = Lifeamount.Point + 1;
            Pointtext.text = "Point:" + Lifeamount.Point;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.CompareTag("Melon"))
        {
            sound();
            Lifeamount.Point = Lifeamount.Point + 3;
            Pointtext.text = "Point:" + Lifeamount.Point;
            Destroy(collision.gameObject);
        }

        
        if (collision.gameObject.CompareTag("Bluegem"))
        {
            sound();
            Lifeamount.Point = Lifeamount.Point +10;
            Pointtext.text = "Point:" + Lifeamount.Point;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Extralife"))
        {
            sound();
            Lifeamount.Life ++;
            Lifetext.text = "X " + Lifeamount.Life;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Resetlife"))
        {
            Lifeamount.Life = 3;
            Lifetext.text = "X " + Lifeamount.Life;
        
        }



    }
    private void sound()
    {
        collect.Play();
    }

}
