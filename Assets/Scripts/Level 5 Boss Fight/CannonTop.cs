using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTop : MonoBehaviour
{
    public GameObject fireButton;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fireButton.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fireButton.SetActive(false);
        }
    }

}
