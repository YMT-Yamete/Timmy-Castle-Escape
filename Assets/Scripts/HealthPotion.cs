using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public AudioSource potionCollectAudio;
    public GameObject potion;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            potionCollectAudio.Play();
            GlobalVariables.currentHealth += 2;
            potion.SetActive(false);
        }
    }
}
