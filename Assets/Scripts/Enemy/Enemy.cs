using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private string currentState = "idle";
    private Transform target;
    public float speed = 5;
    public float gravity = -20;
    public float chaseRange = 12;
    public float attackRange = 3;
    public Animator animator;
    public AudioSource enemyMeet;

    public int health = 3;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.gameOver)
        {
            animator.enabled = false;
            this.enabled = false;
        }
        float distance = Vector3.Distance(transform.position, target.position);
        if (currentState == "idle")
        {
            if (distance < chaseRange)
            {
                currentState = "chase";
            }
        }
        else if (currentState == "chase")
        {
            animator.SetTrigger("chase");
            if (target.position.x == transform.position.x)
            {
                currentState = "idle";
            }
            if(target.position.x > transform.position.x)
            {
                transform.Translate(transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.Translate(-transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (distance<attackRange)
            {
                currentState = "attacking";
            }
        }
        else if (currentState == "attacking")
        {
            animator.SetBool("attacking", true);
            if (distance > attackRange)
            {
                currentState = "chase";
                animator.SetBool("attacking", false);
            }
        }
        if (transform.position.z != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
    public void takeDamage(int damage)
    {
        currentState = "chase";
        enemyMeet.Play();
        health = health - damage;
        if(health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        animator.SetTrigger("die");
        GetComponent<CapsuleCollider>().enabled = false;
        this.enabled = false;
    }
}
