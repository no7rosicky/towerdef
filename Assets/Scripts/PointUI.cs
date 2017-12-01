using UnityEngine.UI;
using UnityEngine;

public class PointUI : MonoBehaviour {
	
	public Text pointsText;
	
	// Update is called once per frame
	void Update () {
		pointsText.text = PlayerStats.Points.ToString();
		
	}
}
