using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using System.IO;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; } // Encapsulation
    void SpawnBlockWave() // create new higher-level method 
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(blockPrefab, GenerateSpawnPosition(),
            blockPrefab.transform.rotation);
        }
    }

    private void Start()
    {
        SpawnBlockWave(); // call higher-level method in Start()
    }
    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}

