using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public AudioSource playerHurt;
    public void attack(int damageAmount)
    {
        GlobalVariables.currentHealth -= damageAmount;
        playerHurt.Play();
    }
}
