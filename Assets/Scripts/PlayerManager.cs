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
    // Start is called before the first frame update
    void Start()
    {
        //  _actionUp.action.Enable();
        //  _actionDown.action.Enable();
        //  _actionUp.action.performed -= MoveUp;
        //  _actionDown.action.performed -= MoveUp;
    }

    // Update is called once per frame
    void Update()
    {
         verticalInput = Input.GetAxis("Vertical");
         if(gameObject.CompareTag("Player"))
         {
         transform.Translate(Vector3.up * Time.deltaTime* _moveSpeed * verticalInput );
         } else
         {
            if(Input.GetKey(KeyCode.Keypad5))
            {
                transform.Translate(Vector3.down *  Time.deltaTime * _moveSpeed);   
            }
            if(Input.GetKey(KeyCode.Keypad8))
            {
                transform.Translate(Vector3.up * Time.deltaTime* _moveSpeed);
            }
         }
         if(transform.position.y > 11)
         {
            transform.position = new Vector3(transform.position.x,11,transform.position.z);
         }
         if(transform.position.y < -3.70f)
         {
            transform.position = new Vector3(transform.position.x,-3.70f,transform.position.z);
         }
    }
    //  public void MoveUp(InputAction.CallbackContext obj)
    //  {
    //      Debug.Log("up");
    //      transform.Translate(new Vector3(0,1,0) * _moveSpeed * Time.deltaTime);
    //  }
    //      public void MoveDown(InputAction.CallbackContext obj)
    //  {
    //      Debug.Log("down");

    //      transform.Translate(new Vector3(0,-1,0) * _moveSpeed * Time.deltaTime);
    //  }
}
