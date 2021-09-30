using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public GameObject key;
    public AudioSource keyCollect;
    public GameObject keyDisplay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keyCollect.Play();
            GlobalVariables.keyCollected = true;
            key.SetActive(false);

            keyDisplay.SetActive(true);
        }
    }
}
