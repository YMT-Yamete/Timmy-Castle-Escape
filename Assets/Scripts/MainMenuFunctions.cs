using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject levelSelectPanel;
    public AudioSource buttonPressed;
    public GameObject totalGemText;

    public GameObject shopPanel;

    private void Start()
    {
        totalGemText.GetComponent<TMPro.TextMeshProUGUI>().text = "Gems: " + PlayerPrefs.GetInt("totalGems").ToString();
        Debug.Log("Total Gems: " + PlayerPrefs.GetInt("totalGems"));
    }
    private void Update()
    {
        
    }
    public void play()
    {
        buttonPressed.Play();
        mainMenuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }
    public void exit()
    {
        buttonPressed.Play();
        Application.Quit();
    }

    public void back()
    {
        buttonPressed.Play();
        mainMenuPanel.SetActive(true);
        shopPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
    }
    public void shop()
    {
        buttonPressed.Play();
        mainMenuPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
}
