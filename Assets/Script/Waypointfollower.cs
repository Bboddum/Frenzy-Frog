using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypointfollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int _currentwaypointindex = 0;
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(waypoints[_currentwaypointindex].transform.position, transform.position) < .1f)
        {
            _currentwaypointindex++;
            if (_currentwaypointindex >= waypoints.Length)
            {
                _currentwaypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[_currentwaypointindex].transform.position, Time.deltaTime * speed);
    }
}