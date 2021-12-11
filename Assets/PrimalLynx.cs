using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    float horizontalMove = 0f;
    float walkSpeed = 7f;
    float jumpHeight = 11f;
    bool jump = false;

    // Start is called before the first frame update
    void Start() // Event BeginPlay (UE4)
    {
        
    }

    // Update is called once per frame
    void Update() // Event Tick (But instead of CPU tick its frame tick)
    {

        /*onGround = false;

        foreach (Transform gc in groundChecks)
            {
            if (Physics2D.OverlapCircle(gc.position, groundCheckRadius, whatIsGround))
            {
                onGround = true;
            }
        }

        if(Input.GetAxis("Horizontal") != 0)
        {

            if(Input.GetAxis("Horizontal") < 0)
            {
                transform.localScale = new Vector3(-7, 7);
            }
            else{
                transform.localScale = new Vector3(7, 7);
            }

            rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * lynxSpeed,0));
        }

        if(Input.GetButton("Jump")) {
            if(onGround) {
                rigidbody2D.AddForce(new Vector2(0,lynxJumpHeight), ForceMode2D.Impulse);
            }
        }*/


        if(Input.GetAxis("Horizontal") != 0)
        {

            if(Input.GetAxis("Horizontal") < 0)
            {
                transform.localScale = new Vector3(-7, 7);
            }
            else{
                transform.localScale = new Vector3(7, 7);
            }
        }

        horizontalMove = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * walkSpeed;

        if(Input.GetButton("Jump") && Mathf.Abs(rigidbody2D.velocity.y) < 0.001f) 
        {
            rigidbody2D.AddForce(new Vector2(0,jumpHeight), ForceMode2D.Impulse);
        }
    }

    /* Lynx Networking */
}
