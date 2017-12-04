using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	
	public void Play () {
		SceneManager.LoadScene("MainScene");
	}
	
	public void Quit () {
		Application.Quit();
	}
}
