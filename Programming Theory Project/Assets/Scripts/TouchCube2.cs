using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCube2 : TouchCube //INHERITANCE FROM PARENT
{
    public override void OnTriggerEnter(Collider other) //POLYMORPHISM PART 2
    {
        Score += 2;
        ScoreText.text = "Score : " + Score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
