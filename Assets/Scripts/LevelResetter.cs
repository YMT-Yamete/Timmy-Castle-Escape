using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelResetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalVariables.gameOver = false;
        GlobalVariables.currentHealth = 5;
        GlobalVariables.coinCollected = 0;
        GlobalVariables.keyCollected = false;
    }
}
