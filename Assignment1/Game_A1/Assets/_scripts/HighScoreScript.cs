/*
Author:Abobaker Belal - 300748727
File:HighScoreScript.cs
Creation date: October 5 
Description: 

Script is for saving the highscore from being destroyed so we can call it again at endgame


*/

using UnityEngine;
using System.Collections;

public class HighScoreScript : MonoBehaviour {

    void Awaker()
    {
        //dont destroy highscore
        DontDestroyOnLoad(this);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
