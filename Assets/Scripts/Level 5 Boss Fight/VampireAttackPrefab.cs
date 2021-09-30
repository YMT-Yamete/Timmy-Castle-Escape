using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampireAttackPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        StartCoroutine(disappear());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GlobalVariables.currentHealth--;
            Destroy(this.gameObject);
        }
    }

    IEnumerator disappear()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
