using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLeft : MonoBehaviour
{
    public GameObject cannon;
    public Animator animator;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cannon.GetComponent<Rigidbody>().AddForce(transform.right * 7);
            animator.SetBool("push", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("push", false);
        }
    }
}
