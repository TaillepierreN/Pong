using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball spawning")]
    [Tooltip("Prefab de balle")]
    [SerializeField] GameObject _ball;
    [Tooltip("Point de spawn")]
    [SerializeField] GameObject _spawn;
    [Tooltip("Texte du score du player 1")]
    [SerializeField] TMP_Text _scoreDisplay1;
    [Tooltip("Texte du score du player 2")]
    [SerializeField] TMP_Text _scoreDisplay2;
    public int scoreP1;
    public int scoreP2;
    int rndmDirection;


    void Start()
    {
        //Set the score to 0
        scoreP1 = 0;
        scoreP2 = 0;

    }

    void Update()
    {
        //If no ball has been spawned,spawn one when Spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.Find("Sphere(Clone)") == null)
        {
            //set the direction of the first throw randomly
            rndmDirection = Random.Range(0, 2);
            if (rndmDirection > 0.5)
                rndmDirection = 1;
            else
                rndmDirection = -1;

            //spawn the ball and push it
            var _spawnedBall = Instantiate(_ball, _spawn.transform.position, _spawn.transform.rotation);
            _spawnedBall.GetComponent<Rigidbody>().AddForce(new Vector3(rndmDirection, 0, 0) * 10, ForceMode.Impulse);
        }
        //display and update the score
        _scoreDisplay1.text = "" + scoreP1;
        _scoreDisplay2.text = "" + scoreP2;
    }
    public void ScoredP1()
    {
        //add one point to Player 1
        scoreP1++;
    }
    public void ScoredP2()
    {
        //add one point to Player 2
        scoreP2++;
    }
}
