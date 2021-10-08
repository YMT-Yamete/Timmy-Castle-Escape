using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHit : MonoBehaviour
{
    public GameObject rockHitEffect;
    public static int damageAmount;

    private void Start()
    {
        damageAmount = PlayerPrefs.GetInt("Damage");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(rockHitEffect, transform.position, rockHitEffect.transform.rotation);
            other.GetComponent<Enemy>().takeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}
