/*
Author:Abobaker Belal - 300748727
File: Enemy_Controller.cs
Creation date:October 2 
Description: 

This script is for determining where and when the enemy(asteroid) will spawn


*/

using UnityEngine;
using System.Collections;


[System.Serializable]
public class Speed
{
    //min and max speed for asteroid right now set to 2 and 10
    public float minSpeed, maxSpeed;
}
[System.Serializable]
public class Drift
{
    //min and max drift speed
    public float minDrift, maxDrift;
}
[System.Serializable]
public class Boundary
{
    //setting boundary for enemy asteroids
    public float xMin, xMax, yMin, yMax;
}
public class Enemy_Controller : MonoBehaviour {


    // Use this for initialization

    //PRIVATE INSTANCE VARIABLES
    private float _CurrentSpeed;
    private float _CurrentDrift;
    //PUBLIC INSTANCE VARIABLES
    public Speed speed;
    public Drift drift;
    public Boundary boundary;
   

    void Start()
    {
        //reset method at start of game
        this._Reset();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.x += this._CurrentDrift;
        currentPosition.y -= this._CurrentSpeed;
        //move background
        gameObject.GetComponent<Transform>().position = currentPosition;
        //boundary check for background
        if (currentPosition.y <= boundary.yMin)
        {
            this._Reset();
        }
    }

    private void _Reset()
    {
        this._CurrentDrift = Random.Range(drift.minDrift, drift.maxDrift);
        this._CurrentSpeed = Random.Range(speed.minSpeed, speed.maxSpeed);
        //position of game
        Vector2 resetPosition = new Vector2(Random.Range(boundary.xMin, boundary.xMax), boundary.yMax);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
