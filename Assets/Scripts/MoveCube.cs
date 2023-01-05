using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float distance;
    int destination;

    void Start()
    {
        //set the cube movement to the right at start
        destination = 1;
    }

    void Update()
    {
        //Move the cube toward the direction(destination) at float speed speed and
        //change the direction of the movement once specifics X coordinate have been reached
        transform.Translate(new Vector3(destination, 0, 0) * speed * Time.deltaTime);
        if (transform.position.x >= distance)
        {
            destination = -1;
        }
        else if (transform.position.x <= -distance)
        {
            destination = 1;
        }
    }
}
