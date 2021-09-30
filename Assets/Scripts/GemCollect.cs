using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public GameObject gem;
    public AudioSource gemCollect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GlobalVariables.coinCollected += 1;
            gemCollect.Play();
            gem.SetActive(false);
        }
    }
}
