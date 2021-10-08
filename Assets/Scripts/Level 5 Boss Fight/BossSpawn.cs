using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSpawn : MonoBehaviour
{
    public GameObject Boss;
    public GameObject bossHealthBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Boss.SetActive(true);
            bossHealthBar.SetActive(true);
        }
    }
}
