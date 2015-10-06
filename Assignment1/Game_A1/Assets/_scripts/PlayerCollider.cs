/*
Author:Abobaker Belal - 300748727
File:PLayerCollider.cs
Creation date:October 2
Description: 

Player collider script for when the player collides with survivors or enemies
player will wither earn points or lose lives


*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    //public instance variable
    public Text scoreLabel;
    public Text livesLabel;
    public Text endGameLabel;
    public Text livesSavedLabel;
    public int scoreValue = 0;
    public int livesValue = 5;

    //private instance variable
    private AudioSource[] _audioSources; // array of audio
    private AudioSource _enemyAudioSource, _survivalAudioSource, _endAudioSource;
    private bool _isColliding;
	// Use this for initialization
	void Start () {
	 this._audioSources = this.GetComponents<AudioSource>();
        this._enemyAudioSource = this._audioSources[1];
        this._survivalAudioSource = this._audioSources[2];
        this._endAudioSource = this._audioSources[3];
        this._isColliding = false;

        this._SetScore();
        this.endGameLabel.enabled = false;
        this.livesSavedLabel.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if(otherGameObject.tag == "Survival_Asteroid")
        {
            this._survivalAudioSource.Play();
            this._isColliding = true;
            this.scoreValue ++; //lives saved
        }
        if (otherGameObject.tag == "Enemy")
        {
            this._enemyAudioSource.Play();
            this._isColliding = true;
            this.livesValue--; //deaths
            if (this.livesValue <= 0)
            {
                this._EndGame();
            }
        }
        this._SetScore();
    }

    //private methid
    private void _SetScore()
    {
        this.scoreLabel.text = "Score: " + this.scoreValue;
        this.livesLabel.text = "Lives: " + this.livesValue;
    }
    void OnTriggerExit2D(Collider2D otherGameObject)
    {
        this._isColliding = false;
    }

    private void _EndGame()
    {
        this._endAudioSource.Play();
        Destroy(gameObject);
        this.scoreLabel.enabled = false;
        this.livesLabel.enabled = false;
        this.endGameLabel.enabled = true;
        this.livesSavedLabel.enabled = true;
        this.livesSavedLabel.text = "Lives Saved: " + this.scoreValue;
        Application.LoadLevel("EndGame");
        
    }
}
