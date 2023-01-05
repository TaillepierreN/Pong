using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] GameManager _gm;
    private void OnTriggerEnter(Collider other)
    {
        //when the ball get into a goal,destroy the ball and call the score up function in the game manager
        Destroy(other.gameObject);
        if (gameObject.CompareTag("TriggerLeft"))
            _gm.ScoredP1();
        else
            _gm.ScoredP2();
    }
}
