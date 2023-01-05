using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    // Start is called before the first frame update
    float _hitPos;
    Vector3 _dir;
    Rigidbody _rb;
    int _speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _speed = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision other) {

        _hitPos = (transform.position.y - other.gameObject.transform.position.y) / 5;
        if(other.gameObject.CompareTag("Player"))
        {
        _dir = new Vector3(1,_hitPos,0).normalized;
        _rb.velocity = _dir * _speed;
        _speed += 2;
        Debug.Log(_speed);
        }
        else if(other.gameObject.CompareTag("Player2"))
        {
        _dir = new Vector3(-1,_hitPos,0).normalized;
        _rb.velocity = _dir * _speed;
        _speed += 2;
        Debug.Log(_speed);
        }

    }
}
