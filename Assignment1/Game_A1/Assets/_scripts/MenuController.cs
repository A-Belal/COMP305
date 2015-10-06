/*
Author:Abobaker Belal - 300748727
File:MenuController.cs
Creation date:October 5 
Description: 

Script for main menu
it will script the button to go to main scene after menu scnee once button is clicked


*/

using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //public methods

    ////start button event handler
    public void OnStartButtonClick()
    {
        //destroy this scene and go to main scene
        Application.LoadLevel("Main");
    }
}
