using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    float _hitPos;
    Vector3 _dir;
    Rigidbody _rb;
    int _speed;
    void Start()
    {
        //get rigidBody of the ball and set the speed
        _rb = GetComponent<Rigidbody>();
        _speed = 10;
    }

    private void OnCollisionEnter(Collision other)
    {
        //store a value between 1 and -1 depending on where on the racket the ball touched,with one 
        //being the top of the racket and -1 the bottom, to determine the angle the ball will go
        //  1 would be higher and -1 lower
        // (ball y position - racket y position) / racket height
        _hitPos = (transform.position.y - other.gameObject.transform.position.y) / 5;
        //check wich player is hit change the velocity of the ball toward the other side
        //augment the speed of the ball each time the ball bounce off a player
        if (other.gameObject.CompareTag("Player"))
        {
            _dir = new Vector3(1, _hitPos, 0).normalized;
            _rb.velocity = _dir * _speed;
            _speed += 2;
            Debug.Log(_speed);
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            _dir = new Vector3(-1, _hitPos, 0).normalized;
            _rb.velocity = _dir * _speed;
            _speed += 2;
            Debug.Log(_speed);
        }

    }
}
