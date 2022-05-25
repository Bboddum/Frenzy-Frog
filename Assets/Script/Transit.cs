using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transit : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Transitpoint;

    void OnTriggerEnter2D(Collider2D Other)
    {
        Player.transform.position = Transitpoint.transform.position;
    }

}
