using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    public static int totalGems = 0; //overall
    public static int coinCollected = 0; // in game level
    public static AudioSource rockHitAudio;
    public TextMeshProUGUI NumberOfGemsText; // in game level
    public static int currentHealth = 5; // in game level
    public Slider healthBar;
    public static bool gameOver = false;
    public GameObject gameOverPanel;
    public static bool keyCollected = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfGemsText.text = "Gems: " + coinCollected;

        healthBar.value = currentHealth;

        if(currentHealth <= 0)
        {
            gameOver = true;
        }
        if (gameOver == true)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
