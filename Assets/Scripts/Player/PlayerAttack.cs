using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject shootedRock;
    public Transform attackPoint;
    public float speed = 1; 
    public void rockAttack()
    {
        GameObject rock = Instantiate(shootedRock, attackPoint.position, Quaternion.identity);
        rock.GetComponent<Rigidbody>().AddForce(attackPoint.forward * speed);
    }
}
