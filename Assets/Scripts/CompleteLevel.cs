using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public AudioSource completeLevelAudio;
    public AudioSource gameAudio;
    public GameObject completePanel;
    public GameObject joyStick;
    public string nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemies in gameObjectArray)
            {
                enemies.SetActive(false);
            }
            joyStick.SetActive(false);
            completePanel.SetActive(true);
            completeLevelAudio.Play();
            gameAudio.Pause();
            GlobalVariables.totalGems = GlobalVariables.totalGems + GlobalVariables.coinCollected;
            PlayerPrefs.SetInt("totalGems", GlobalVariables.totalGems);
            PlayerPrefs.SetString(nextLevel, "Unlocked");
            Debug.Log("You Win");
        }
    }
}
