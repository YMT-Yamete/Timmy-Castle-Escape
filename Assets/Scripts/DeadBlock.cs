using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GlobalVariables.currentHealth = 0;
        }
    }
}
