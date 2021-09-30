using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject CannonBullet;
    public Transform FirePoint;
    public AudioSource FireAudio;
    private bool CanShoot = true;
    public void Fire()
    {
        if (CanShoot)
        {
            StartCoroutine(ShootAndWait());
        }
    }

    IEnumerator ShootAndWait()
    {
        CanShoot = false;
        FireAudio.Play();
        GameObject cannonBullet = Instantiate(CannonBullet, FirePoint.position, Quaternion.identity);
        cannonBullet.GetComponent<Rigidbody>().AddForce(FirePoint.forward * 800);
        yield return new WaitForSeconds(2);
        CanShoot = true;
    }
}
