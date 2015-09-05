using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProcessQuestion : MonoBehaviour {

	public SpriteRenderer render;

	private Question currentQuestion;
	private List<int> answered;

	void Start () {
		answered = new List<int>();
		currentQuestion = new Question(nextQuestion());
	}

	void Update () {
		render.sprite = currentQuestion.GetSprite ();
	}

	public void TestAnswer(string input) {
		if (input.ToLower().Replace(" ", "" ) == currentQuestion.GetAnswer()) {
			currentQuestion = new Question(nextQuestion());
		}else {
			Debug.Log ("Wrong");
		}
		
	}

	private int nextQuestion() {

		int index = Random.Range (0, 33);
		/*do {
			index = Random.Range (0, 33);
		}while(!answered.Contains (index));*/
		Debug.Log (answered.Contains (index));
		for(int i = 0; i < answered.Count; i++) {
			Debug.Log(answered.ToArray()[i]);
		}
		answered.Add (index);
		return index;
	}
}
