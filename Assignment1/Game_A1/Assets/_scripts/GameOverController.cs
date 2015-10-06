/*
Author:Abobaker Belal - 300748727
File: GameOVerController.cs
Creation date: October 5
Description: 

Script for end game, it is for the button to restart the game


*/

using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnRestartButtonClick()
    {
        //destroy this scene and go to main
        Application.LoadLevel("Main");
    }
}
