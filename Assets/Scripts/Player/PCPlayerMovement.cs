using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCPlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject gameChar;
    private Vector3 direction;
    public float speed = 8;
    public float jumpForce = 12;
    public float gravity = -20;
    public Transform groundCheck;
    public Transform player;
    public LayerMask groundLayer;
    public LayerMask enemyLayer;
    private bool doubleJumpChecker = true;

    public Animator animator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.gameOver)
        {
            animator.SetTrigger("die");
            this.enabled = false;
        }

        float horizontalInput = Input.GetAxis("Horizontal");

        direction.x = horizontalInput * speed;

        animator.SetFloat("speed", Mathf.Abs(horizontalInput));

        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);
        direction.y += gravity * Time.deltaTime;

        if (isGrounded)
        {
            doubleJumpChecker = true;
            if (Input.GetKeyDown("space"))
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("throwRock");
            }
        }
        else
        {
            if (Input.GetKeyDown("space") && doubleJumpChecker)
            {
                DoubleJump();
            }
        }

        float moveFromHead = 0;
        if (Physics.CheckSphere(groundCheck.position, 0.15f, enemyLayer))
        {
            if (gameChar.transform.rotation.y < 0)
            {
                moveFromHead = -1;
            }
            else if (gameChar.transform.rotation.y > 0)
            {
                moveFromHead = 1;
            }
            direction.x += 10 * moveFromHead;
        }

        if (horizontalInput != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, 0));
            player.rotation = newRotation;
        }
        controller.Move(direction * Time.deltaTime);

        if (transform.position.z != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }

    public void DoubleJump()
    {
        Debug.Log("dobule jump");
        animator.SetTrigger("doubleJump");
        doubleJumpChecker = false;
        direction.y = jumpForce;
    }
    public void Jump()
    {
        Debug.Log("jump");
        direction.y = jumpForce;
    }
}
