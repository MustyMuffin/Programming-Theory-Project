using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text ScoreText; 

private int Score = 0;

    private void Start()
    {
        Score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Score += 1;
        ScoreText.text = "Score : " + Score;
    }
}
