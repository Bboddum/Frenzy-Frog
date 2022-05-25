using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transit_tostart : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Transitpoint;
    public GameObject ToEnable;
    public GameObject ToDisable;
    public GameObject remove;
    void OnTriggerEnter2D(Collider2D Other)
    {
        ToEnable.SetActive(true);
        ToDisable.SetActive(false);
        Destroy(remove);

        Player.transform.position = Transitpoint.transform.position;
    }
}
