using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text scoreText;

	void OnEnable ()
	{
		scoreText.text = PlayerStats.Points.ToString();
	}
	public void Retry ()
	{
		SceneManager.LoadScene ("MainScene");
	}
	public void Quit ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
