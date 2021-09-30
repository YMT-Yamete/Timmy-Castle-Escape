using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public GameObject useKey;
    public GameObject door;
    public AudioSource doorOpenAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GlobalVariables.keyCollected)
            {
                useKey.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        useKey.SetActive(false);
    }

    public void doorOpen()
    {
        doorOpenAudio.Play();
        useKey.SetActive(false);
        door.SetActive(false);
    }
}
