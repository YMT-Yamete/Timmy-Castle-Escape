using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRock : MonoBehaviour
{
    public AudioSource playerHurt;
    public GameObject rock;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GlobalVariables.currentHealth -= 1;
            playerHurt.Play();
            rock.SetActive(false);
        }
    }

}
