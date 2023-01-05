using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] GameManager _gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        if(gameObject.CompareTag("TriggerLeft"))
        _gm.ScoredP1();
        else
        _gm.ScoredP2();
    }
}
