﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    public float RestartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame ()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", RestartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void CompleteLevel()
    {
        Debug.Log("Level 1 complete");
        completeLevelUI.SetActive(true);
    }

}
