using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    //[SerializeField] InputActionReference _actionUp;
    //[SerializeField] InputActionReference _actionDown;
    [SerializeField] float _moveSpeed;

    private float verticalInput;

    void Update()
    {
        //get vertical input and if script is applied to the gameObject tagged"Player", move the 
        //gameObject
        verticalInput = Input.GetAxis("Vertical");
        if (gameObject.CompareTag("Player"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * _moveSpeed * verticalInput);
        }
        else
        //if the gameObject is not tagged "Player", it moves the second player with key 8 and 5 from
        // keypad
        {
            if (Input.GetKey(KeyCode.Keypad5))
            {
                transform.Translate(Vector3.down * Time.deltaTime * _moveSpeed);
            }
            if (Input.GetKey(KeyCode.Keypad8))
            {
                transform.Translate(Vector3.up * Time.deltaTime * _moveSpeed);
            }
        }
        //place boundaries for player not to go too for up or down
        if (transform.position.y > 12f)
        {
            transform.position = new Vector3(transform.position.x, 12f, transform.position.z);
        }
        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(transform.position.x, -5f, transform.position.z);
        }
    }
    /*
    tried to use new input system, but failed miserably
    void Start()
    {

        _actionUp.action.Enable();
        _actionDown.action.Enable();
        _actionUp.action.performed -= MoveUp;
        _actionDown.action.performed -= MoveUp;
    }
    public void MoveUp(InputAction.CallbackContext obj)
    {
        Debug.Log("up");
        transform.Translate(new Vector3(0, 1, 0) * _moveSpeed * Time.deltaTime);
    }
    public void MoveDown(InputAction.CallbackContext obj)
    {
        Debug.Log("down");
        transform.Translate(new Vector3(0, -1, 0) * _moveSpeed * Time.deltaTime);
    }
    */
}
