using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float distance;
    int destination;

    // Start is called before the first frame update
    void Start()
    {
        destination = 1;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(destination,0,0) * speed * Time.deltaTime);
        if (transform.position.x >= distance)
        {
            destination = -1;
        }
        else if(transform.position.x <= -distance)
        {
            destination = 1;
        }
    }
}
