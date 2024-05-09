using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHazard : MonoBehaviour
{
    public Transform[] waypoints;
    int i = 0;

    void FixedUpdate()
    {
        if (transform.position != waypoints[i].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[i].position, 3 * Time.deltaTime);
        }
        else
        {
            if (i == waypoints.Length - 1)
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
