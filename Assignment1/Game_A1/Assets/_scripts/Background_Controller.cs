/*
Author:Abobaker Belal - 300748727
File:Background_Controller.cs
Creation date:September 25
Description: 

this script is for the background, which will determine when it will reset


*/
using UnityEngine;
using System.Collections;

public class Background_Controller : MonoBehaviour {

    
    //PUBLIC INSTANCE VARIABLES
    //speed for background
    public float speed;


	void Start () {
        //reset method at start of game
        this._Reset();
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y -= speed;
        //move background
        gameObject.GetComponent<Transform>().position = currentPosition;
        //boundary check for background
        if (currentPosition.y <= -480)
        {
            //reset method is called once position is -480
            this._Reset();
        }
	
	}

    private void _Reset()
    {
        //position of game
        Vector2 resetPosition = new Vector2(0.0f, 480f);
        gameObject.GetComponent<Transform> ().position = resetPosition;
    }
}
