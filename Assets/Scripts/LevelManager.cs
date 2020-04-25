﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
       // Debug.Log("Load Level requested for:" + name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Quit requested by User");
    }
    public void LoadNextLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void BrickDestroyed()
    {
        if(Bricks.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
