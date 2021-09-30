using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRedirector : MonoBehaviour
{
    public AudioSource buttonPressed;
    public void redirectMainMenu()
    {
        buttonPressed.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
    public void redirectLevel1()
    {
        buttonPressed.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(2);
    }
    public void redirectLevel2()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level2")=="Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(3);
        }
    }
    public void redirectLevel3()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level3") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(4);
        }
    }
    public void redirectLevel4()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level4") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(5);
        }
    }
    public void redirectLevel5()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level5") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(6);
        }
    }
    public void redirectLevel6()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level6") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(7);
        }
    }
    public void redirectLevel7()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level7") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(8);
        }
    }
    public void redirectLevel8()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level8") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(9);
        }
    }
    public void redirectLevel9()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level9") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(10);
        }
    }
    public void redirectLevel10()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level10") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(11);
        }
    }
    public void redirectLevel11()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level11") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(12);
        }
    }
    public void redirectLevel12()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level12") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(13);
        }
    }
    public void redirectLevel13()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level13") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(14);
        }
    }
    public void redirectLevel14()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level14") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(15);
        }
    }
    public void redirectLevel15()
    {
        buttonPressed.Play();
        if (PlayerPrefs.GetString("Level15") == "Unlocked")
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(16);
        }
    }
}
