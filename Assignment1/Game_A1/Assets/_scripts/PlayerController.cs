/*
Author:Abobaker Belal - 300748727
File: PLayerController.cs
Creation date:September 29
Description: 

script for controlling the player
also set boundaries so player cannot leave screen or go too far ahead of screen


*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //public instance variable
    public float speed;
    public Boundary boundary;


    //private instance variable
    private Vector2 _newPosition = new Vector2(0.0f, 0.0f);

	// Use this for initialization
	void Start () {
        Debug.Log("Player Entered Scene");
	}
	
	// Update is called once per frame
	void Update () {
        this._ChechInput();

    }

    private void _ChechInput()
    {
        this._newPosition = gameObject.GetComponent<Transform>().position; //curent position

        if (Input.GetAxis("Horizontal") > 0)
        {
            this._newPosition.x += this.speed; // add move value to current position
            gameObject.GetComponent<Transform>().position = this._newPosition;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            this._newPosition.x -= this.speed; // add move value to current position
            gameObject.GetComponent<Transform>().position = this._newPosition;
        }
        
        if (Input.GetAxis("Vertical") > 0)
        {
           this._newPosition.y += this.speed; // add move value to current position
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            this._newPosition.y -= this.speed; // add move value to current position
        }
        
        this._BoundaryCheck();

        gameObject.GetComponent<Transform>().position = _newPosition;
    }

    private void _BoundaryCheck()
    {
        if(this._newPosition.x < boundary.xMin)
        {
            this._newPosition.x = this.boundary.xMin;
        }
        if (this._newPosition.x > boundary.xMax)
        {
            this._newPosition.x = this.boundary.xMax;
        }
        if (this._newPosition.y < boundary.yMin)
        {
            this._newPosition.y = this.boundary.yMin;
        }
        if (this._newPosition.y > boundary.yMax)
        {
            this._newPosition.y = this.boundary.yMax;
        }
    }
}
