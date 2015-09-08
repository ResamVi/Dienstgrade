using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int score;
	private int total;
	public Text text;

	void Start () {
		score = 0;
		total = 0;
	}

	void Update () {
		text.text = score + " von " + total + " richtig.";
	}

	public void UpdateScore(bool correct) {
		if (correct)
			score++;

		if (total == 33)
			Application.LoadLevel (3);

		total++;


	}
}
