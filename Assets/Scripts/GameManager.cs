using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool gameEnded;
	public GameObject gameOverUI;
	
	// Update is called once per frame

	void Start ()
	{
		gameEnded = false;
	}
	void Update () {
		if(gameEnded)
			return;
		if(Input.GetKeyDown("q"))
		{
			EndGame();
		}
		if (PlayerStats.Lives <= 0)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		gameEnded = true;
		gameOverUI.SetActive(true);
	}
}
