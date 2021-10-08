using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopFunctions : MonoBehaviour
{
    public Slider jumpForceSlider;
    public Slider speedSlider;
    public Slider damageSlider;

    public GameObject jumpForceUpButton;
    public GameObject speedUpButton;
    public GameObject damageUpButton;
    public AudioSource buttonPressed;

    public GameObject totalGemText;
    public GameObject jumpForceText;
    public GameObject speedText;
    public GameObject damageText;

    public GameObject notEnoughGemPanel;
    public GameObject shopPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpForceSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("JumpForce");
        speedSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Speed");
        damageSlider.GetComponent<Slider>().value = PlayerPrefs.GetInt("Damage");

        damageText.GetComponent<TMPro.TextMeshProUGUI>().text = "Damage: " + PlayerPrefs.GetInt("Damage").ToString();
        speedText.GetComponent<TMPro.TextMeshProUGUI>().text = "Speed: " + PlayerPrefs.GetFloat("Speed").ToString();
        jumpForceText.GetComponent<TMPro.TextMeshProUGUI>().text = "Jump Force: " + PlayerPrefs.GetFloat("JumpForce").ToString();

        if (PlayerPrefs.GetFloat("JumpForce") >= jumpForceSlider.GetComponent<Slider>().maxValue)
        {
            jumpForceUpButton.SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Speed") >= speedSlider.GetComponent<Slider>().maxValue)
        {
            speedUpButton.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Damage") >= damageSlider.GetComponent<Slider>().maxValue)
        {
            damageUpButton.SetActive(false);
        }
    }

    public void jumpForceUp()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetInt("totalGems") >= 100)
        {
            PlayerPrefs.SetFloat("JumpForce", PlayerPrefs.GetFloat("JumpForce") + 1f);
            PlayerPrefs.SetInt("totalGems", PlayerPrefs.GetInt("totalGems") - 100);
            totalGemText.GetComponent<TMPro.TextMeshProUGUI>().text = "Gems: " + PlayerPrefs.GetInt("totalGems").ToString();
        }
        else
        {
            notEnoughGemPanel.SetActive(true);
            shopPanel.SetActive(false);
        }
    }
    public void speedUp()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetInt("totalGems") >= 100)
        {
            PlayerPrefs.SetFloat("Speed", PlayerPrefs.GetFloat("Speed") + 1f);
            PlayerPrefs.SetInt("totalGems", PlayerPrefs.GetInt("totalGems") - 100);
            totalGemText.GetComponent<TMPro.TextMeshProUGUI>().text = "Gems: " + PlayerPrefs.GetInt("totalGems").ToString();
        }
        else
        {
            notEnoughGemPanel.SetActive(true);
            shopPanel.SetActive(false);
        }
    }
    public void damageUp()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetInt("totalGems") >= 100)
        {
            PlayerPrefs.SetInt("Damage", PlayerPrefs.GetInt("Damage") + 1);
            PlayerPrefs.SetInt("totalGems", PlayerPrefs.GetInt("totalGems") - 100);
            totalGemText.GetComponent<TMPro.TextMeshProUGUI>().text = "Gems: " + PlayerPrefs.GetInt("totalGems").ToString();
        }
        else
        {
            notEnoughGemPanel.SetActive(true);
            shopPanel.SetActive(false);
        }
    }
    public void backToShop()
    {
        buttonPressed.Play();
        notEnoughGemPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
}
