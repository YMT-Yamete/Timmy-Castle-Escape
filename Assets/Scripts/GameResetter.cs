using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("FirstLogin") != "No")
        {
            PlayerPrefs.SetInt("totalGems", 0);
            PlayerPrefs.SetFloat("JumpForce", 12f);
            PlayerPrefs.SetFloat("Speed", 10f);
            PlayerPrefs.SetInt("Damage", 1);
            PlayerPrefs.SetString("FirstLogin", "No");
            Debug.Log("Done");
        }
    }

    private void Update()
    {

    }
}
