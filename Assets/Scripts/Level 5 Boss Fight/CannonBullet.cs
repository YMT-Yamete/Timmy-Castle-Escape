using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{
    public GameObject Effect;
    public AudioSource BulletCollideAudio;

    private void Update()
    {
        StartCoroutine(BulletDisappear());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vampire")
        {
            BulletCollideAudio.Play();
            Vampire.Health--;
            Effect.SetActive(true);
            StartCoroutine(CollidedBulletDisappear());
        }
    }
    
    IEnumerator CollidedBulletDisappear()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }

    IEnumerator BulletDisappear()
    {
        yield return new WaitForSeconds(8);
        Destroy(this.gameObject);
    }
}
