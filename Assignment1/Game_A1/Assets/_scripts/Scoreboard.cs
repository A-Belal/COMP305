/*
Author:Abobaker Belal - 300748727
File:asteroidSurvival_Controller.cs
Creation date:october 4 
Description: 

script for controlling the scoreboard
and what happens once player has zero lives

*/

using UnityEngine;
using System.Collections;

public class Scoreboard : MonoBehaviour {
    //private instance variables
    private AudioSource[] _audioSources; // an array of AudioSources
    private AudioSource _endGameAudio;
    // Use this for initialization
    void Start () {
        this._audioSources = this.GetComponents<AudioSource>();
        this._endGameAudio = this._audioSources[0];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
