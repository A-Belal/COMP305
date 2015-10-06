/*
Author:Abobaker Belal - 300748727
File: GameController.cs
Creation date:September 29
Description: 
game controller for main scene, 
it will control how many enemies will spawn


*/

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //public instance variables
    public int enemyCount;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
        this._SpawnEnemy();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //enemy spawn
    private void _SpawnEnemy()
    {
        for (int count = 0; count< this.enemyCount; count++)
        {
            Instantiate(enemy);
        }
    }
}
