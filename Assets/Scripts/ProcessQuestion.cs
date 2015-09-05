using UnityEngine;
using System.Collections;

public class ProcessQuestion : MonoBehaviour {

	public SpriteRenderer renderer;

	private Question currentQuestion;

	void Start () {
		int number = (int)Random.Range (0, 33);
		currentQuestion = new Question (number);
	}

	void Update () {
		renderer.sprite = currentQuestion.GetSprite ();

	}

	public void TestAnswer(string input) {
		Debug.Log (input + " - vs. - " + currentQuestion.GetAnswer ());
		if (input.ToLower() == currentQuestion.GetAnswer ().ToLower()) {
			Debug.Log ("Correct");
		} else {
			Debug.Log ("Wrong");
		}
	}
}
