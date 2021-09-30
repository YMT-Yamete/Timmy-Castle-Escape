using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventFunctions : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource buttonAudio;
    public void pause()
    {
        buttonAudio.Play();
        pausePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void resume()
    {
        buttonAudio.Play();
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void playAgain()
    {
        buttonAudio.Play();
        GlobalVariables.currentHealth = 5;
        GlobalVariables.gameOver = false;
        GlobalVariables.coinCollected = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
    public void exit()
    {
        buttonAudio.Play();
        Application.Quit();
    }
}
