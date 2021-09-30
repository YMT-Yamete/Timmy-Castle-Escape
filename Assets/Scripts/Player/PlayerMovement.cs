using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
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
    public GameObject joystickHandle;
    public bool jumpStatus = false;
    public bool attackStatus = false;

    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = 0;
        float joystickPosX =  joystickHandle.GetComponent<RectTransform>().anchoredPosition.x;
        if (joystickPosX < 0)
        {
            horizontalMovement = -1;
        }
        else if(joystickPosX > 0)
        {
            horizontalMovement = 1;
        }

        if(GlobalVariables.gameOver)
        {
            animator.SetTrigger("die");
            this.enabled = false;
        }
        //float horizontalInput = Input.GetAxis("Horizontal");

        direction.x = horizontalMovement * speed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMovement));

        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);
        direction.y += gravity * Time.deltaTime;

        if (isGrounded)
        {
            doubleJumpChecker = true;
            if (jumpStatus)
            {
                Jump();
                jumpStatus = false;
            }
            if (attackStatus)
            {
                animator.SetTrigger("throwRock");
                attackStatus = false;
            }
        }
        else
        {
            if (jumpStatus && doubleJumpChecker)
            {
                DoubleJump();
            }
            jumpStatus = false;
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

        if (horizontalMovement != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(horizontalMovement, 0, 0));
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
        animator.SetTrigger("doubleJump");
        doubleJumpChecker = false;
        direction.y = jumpForce;
    }
    public void Jump()
    {
        direction.y = jumpForce;
    }
    public void jumpButtonPressed()
    {
        jumpStatus = true;
    }
    public void attackButtonPressed()
    {
        attackStatus = true;
    }
}
