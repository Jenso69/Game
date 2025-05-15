using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpForce = 2f;
    public LayerMask whatIsGround;

    private float moveDirection;
    public bool isGrounded;



    private Animator animator;
    private Rigidbody2D playerRb;
    private SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRb.linearVelocityX = moveDirection * moveSpeed;

        GroundCheck();
    }



    private void OnMove(InputValue value)
    {

        Vector2 input = value.Get<Vector2>();
        moveDirection = input.x;

        if (input.x != 0)
        {
            spriteRenderer.flipX = (input.x < 0);
        }


        //set the animator boolean to true or false
        animator.SetBool("Is Moving", moveDirection != 0);
    }

    private void OnJump(InputValue value)
    {
        //to ensure the character always jumps in a specific speed
        playerRb.linearVelocityY = jumpForce;
    
    }
    private void GroundCheck()
    {

       RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.1f,0, Vector2.down, 0.2f, whatIsGround.value);

        isGrounded = hit.collider != null;

    }


}
