using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocks : MonoBehaviour
{
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    public GameObject level10;
    public GameObject level11;
    public GameObject level12;
    public GameObject level13;
    public GameObject level14;
    public GameObject level15;
    public GameObject level16;
    public GameObject level17;
    public GameObject level18;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("Level2")=="Unlocked")
        {
            level2.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level3") == "Unlocked")
        {
            level3.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level4") == "Unlocked")
        {
            level4.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level5") == "Unlocked")
        {
            level5.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level6") == "Unlocked")
        {
            level6.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level7") == "Unlocked")
        {
            level7.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level8") == "Unlocked")
        {
            level8.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level9") == "Unlocked")
        {
            level9.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level9") == "Unlocked")
        {
            level9.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level10") == "Unlocked")
        {
            level10.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level11") == "Unlocked")
        {
            level11.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level12") == "Unlocked")
        {
            level2.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level13") == "Unlocked")
        {
            level13.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level14") == "Unlocked")
        {
            level14.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level15") == "Unlocked")
        {
            level15.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level16") == "Unlocked")
        {
            level16.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level17") == "Unlocked")
        {
            level17.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level18") == "Unlocked")
        {
            level18.SetActive(false);
        }
    }
}
