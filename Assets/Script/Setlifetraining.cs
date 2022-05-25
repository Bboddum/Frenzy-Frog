using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setlifetraining : MonoBehaviour
{
    [SerializeField] private GameObject remove;
    [SerializeField] private Text Lifetext;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Lifeamount.Life = 30;
        Lifetext.text = "X " + Lifeamount.Life;
        Destroy(remove);
    }
}
