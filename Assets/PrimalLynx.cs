using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimalLynx : NetworkBehaviour
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

    // Start is called before the first frame update
    void Start() // Event BeginPlay (UE4)
    {
        
    }

    // Update is called once per frame
    void Update() // Event Tick (But instead of CPU tick its frame tick)
    {
        onGround = false;

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
        }
    }

    void OnUpdate_lynxmovement_fancystuff() 
    {

    }

    /* Lynx Networking */

    public override void OnStartServer()
    {
        // disable client stuff
    }

    public override void OnStartClient()
    {
        // register client events, enable effects
    }
}
