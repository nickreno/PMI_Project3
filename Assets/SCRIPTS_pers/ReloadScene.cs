using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{
    public string levelToLoad;
    public GameObject deadCanvas;
    public GameObject startingCanvas;

    public void LoadTheGameLevel()
    {
        startingCanvas.SetActive(true);
        deadCanvas.SetActive(false);
        CeilingCollapse.timeRemaining = 12;
        DeathByCeiling.isSafe = false;

        Application.LoadLevel(levelToLoad);
        
    }
}