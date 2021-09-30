using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : MonoBehaviour
{
    public static int Health = 7;
    public Animator animator;
    public AudioSource DieAudio;
    public Transform zombieSpawner;
    public Transform zombieSpawner1;
    public GameObject zombie;
    private bool spawnDone = false;

    void Start()
    {
        Health = 7;   
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Fight(3));
        if (Health< 3 && !spawnDone)
        {
            Instantiate(zombie, zombieSpawner.position, Quaternion.identity);
            Instantiate(zombie, zombieSpawner1.position, Quaternion.identity);
            spawnDone = true;
        }
        if (Health <= 0)
        {
            Debug.Log("Vampire Die");
            animator.SetTrigger("Die");
            DieAudio.Play();
            this.enabled = false;
        }
    }
    IEnumerator Fight(int seconds)
    {
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(seconds);
    }
}
