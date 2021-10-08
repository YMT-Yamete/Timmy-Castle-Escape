using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vampire : MonoBehaviour
{
    public static int Health = 7;
    public Animator animator;
    public AudioSource DieAudio;
    public Transform zombieSpawner;
    public Transform zombieSpawner1;
    public GameObject zombie;
    private bool spawnDone = false;
    public GameObject gemHolder;
    public GameObject skull;
    public Slider bossHealthBar;

    void Start()
    {
        Health = 8;
        bossHealthBar.maxValue = Health;
    }

    // Update is called once per frame
    void Update()
    {
        bossHealthBar.value = Health;
        StartCoroutine(Fight(3));
        if (Health< 4 && !spawnDone)
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
            gemHolder.SetActive(true);
            skull.SetActive(false);
        }
    }
    IEnumerator Fight(int seconds)
    {
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(seconds);
    }
}
