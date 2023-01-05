using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] GameObject _spawn;
    public int scoreP1;
    public int scoreP2;
    [SerializeField] TMP_Text _scoreDisplay1;
    [SerializeField] TMP_Text _scoreDisplay2;

    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var _spawnedBall = Instantiate(_ball, _spawn.transform.position, _spawn.transform.rotation);
            _spawnedBall.GetComponent<Rigidbody>().AddForce(Vector3.left * 10,ForceMode.Impulse);
        }
        _scoreDisplay1.text = "" + scoreP1;
        _scoreDisplay2.text = "" + scoreP2;
    }
    public void ScoredP1()
    {
        scoreP1++;
    }
    public void ScoredP2()
    {
        scoreP2++;
    }
}
