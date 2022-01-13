using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class TouchCube : MonoBehaviour
{
    public Text ScoreText; 

public int Score = 0;

    private void Start()
    {
        Score = 0;
    }

    public virtual void OnTriggerEnter(Collider other) //POLYMORPHISM STEP 1
    {
        Score += 1;
        ScoreText.text = "Score : " + Score;
    }
}
