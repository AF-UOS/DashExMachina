using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHazard : MonoBehaviour
{
    public Transform[] waypoints;
    static int length;
    int i = 0;

    void Start()
    {
        int length = waypoints.Length;
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, waypoints[i].position) < 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[i].position, Time.deltaTime);
        }
        else
        {
            if (i == length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
    }
}
