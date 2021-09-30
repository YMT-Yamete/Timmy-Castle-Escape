using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseAttack : MonoBehaviour
{
    public GameObject VampireAttack;
    public Transform attackPoint;
    public Transform target;
    // Start is called before the first frame update
    public void releaseAttack()
    {
        GameObject vampireAttack = Instantiate(VampireAttack, attackPoint.position, Quaternion.identity);
        vampireAttack.GetComponent<Rigidbody>().AddForce((target.position - attackPoint.position) * 50);
    }
}
