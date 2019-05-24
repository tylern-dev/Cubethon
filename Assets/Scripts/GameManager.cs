﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()  
    {
        if(gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
            // Restart Game
            Invoke("Restart", restartDelay);
            //Restart();
        }


    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
