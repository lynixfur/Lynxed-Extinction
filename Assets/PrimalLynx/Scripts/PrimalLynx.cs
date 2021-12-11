using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PrimalLynx : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float lynxSpeed;
    public float lynxJumpHeight;
    public SpriteRenderer lynxRenderer;

    // Not my stuff
    public Transform[] groundChecks;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    // Primal Movement Controller
    public PlayerInput lynxInput;
    public LynxControlActions lynxInputActions;
    float horizontalMove = 0f;
    float walkSpeed = 7f;
    float jumpHeight = 11f;
    bool jump = false;


    private void Awake()
    {

        //lynxInput = new LynxCon

        lynxInputActions = new LynxControlActions();
        lynxInputActions.Enable();
        lynxInputActions.Lynx.Jump.performed += Jump;
        //lynxInputActions.Lynx.Move.performed += Move;
    }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext ctx) {
        Debug.Log(ctx);
    }

    void Update()
    {
        //horizontalMove = Input.GetAxis("Horizontal");
        Vector2 horizontalMove = lynxInputActions.Lynx.Move.ReadValue<Vector2>();
        transform.position += new Vector3(horizontalMove.x, 0f, 0f) * Time.deltaTime * walkSpeed;

        if(horizontalMove.x < 0)
        {
            transform.localScale = new Vector3(-7, 7);
        }
        else{
            transform.localScale = new Vector3(7, 7);
        }
    }

    public void Move(InputAction.CallbackContext ctx) 
    {
        Vector2 inputVector = ctx.ReadValue<Vector2>();
        transform.position += new Vector3(inputVector.x, 0, 0) * Time.deltaTime * walkSpeed;
    }

    public void Jump(InputAction.CallbackContext ctx) 
    {
        if(Mathf.Abs(rigidbody2D.velocity.y) < 0.001f) 
        {
            rigidbody2D.AddForce(new Vector2(0,jumpHeight), ForceMode2D.Impulse);
            Debug.Log("PrimalLynx: Client Controller Jumped!");
        }
    }

    /* Lynx Networking */
    /* Dedicated Servers are not officially supported by Lynxed Extinction right now! */

    public string GetUsername() {
        //return pgd.NetworkUsername();
        return "Username";
    }

    public string GetUserID() {
        //return pgd.NetworkIdentifcation();
        return "0";
    }
}
