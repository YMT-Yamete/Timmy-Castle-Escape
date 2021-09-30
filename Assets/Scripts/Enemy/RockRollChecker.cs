using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRollChecker : MonoBehaviour
{
    public GameObject rock;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rock.SetActive(true);
        }
    }
}
