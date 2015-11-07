using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Levels : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CheckScore(int cubesScore, int spheresScore)
    {
        if(cubesScore > 100 && spheresScore > 100)
        {
            // go to the next level 
            Application.LoadLevel("PacMan");
        }
        if(cubesScore > 200 && spheresScore > 200)
        {
            Application.LoadLevel("Pong");
        }
    }
}
