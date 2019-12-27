﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("LEVEL WON!");
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            //Restart game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }


}
