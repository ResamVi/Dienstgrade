using UnityEngine;
using System.Collections;

public class Question {

	private Sprite[] list;
	private Sprite question;
	private string answer;

	public Question(int index) {
		list = Resources.LoadAll <Sprite>("Sprites");
		question = list [index+1];
		answer = QuestionDatabase.getAnswer (index);
	}

	public Sprite GetSprite() {
		return question;
	}

	public string GetAnswer() {
		return answer;
	}
}
