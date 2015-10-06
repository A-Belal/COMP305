/*
Author:Abobaker Belal - 300748727
File:asteroidSurvival_Controller.cs
Creation date:September 29
Description: 

this script is for the survival asteroids, this will determine where and when the survivals will spawn for the
player to see and try to save.


*/

using UnityEngine;
using System.Collections;

public class asteroidSurvival_Controller : MonoBehaviour
{


    //PUBLIC INSTANCE VARIABLES
    //speed for asteroid
    public float speed;


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
        currentPosition.y -= speed;
        //move background
        gameObject.GetComponent<Transform>().position = currentPosition;
        //boundary check for background
        if (currentPosition.y <= -285)
        {
            //calling reset method once asteroid leaves screen
            this._Reset();
        }
    }

    private void _Reset()
    {
        //position of game
        Vector2 resetPosition = new Vector2(Random.Range(-290f, 282f), 285f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}