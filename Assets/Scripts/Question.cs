using UnityEngine;
using System.Collections;

public class Question {

	private Sprite[] list;
	private Sprite question;
	private string answer;

	public Question(int index) {
		list = Resources.LoadAll <Sprite>("Sprites");
		question = list [index];
		Debug.Log (list.Length);
		answer = QuestionDatabase.getAnswer (index);
		Debug.Log (answer);
	}

	public Sprite GetSprite() {
		return question;
	}

	public string GetAnswer() {
		return answer;
	}
}
