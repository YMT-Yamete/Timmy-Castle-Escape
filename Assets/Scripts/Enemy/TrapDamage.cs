using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    public AudioSource playerHurt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("goddo");
            GlobalVariables.currentHealth -= 1;
            playerHurt.Play();
        }
    }
}
