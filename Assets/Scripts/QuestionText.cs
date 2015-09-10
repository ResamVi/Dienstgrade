using UnityEngine;
using System.Collections;

public class QuestionText {
	
	private Sprite[] list;
	private Sprite[] questions;
	private string answer;
	private string question;

	public QuestionText(int index) {
		list = Resources.LoadAll <Sprite>("Sprites");
		question = "Welcher ist der " + QuestionDatabase.getAnswer (index);
		questions [0] = list [index];
		// NEED TO TEST!
		//questions [1] = list [index + Mathf.RoundToInt (Random.Range (1, 3))];
		//questions [2] = list [index - Mathf.RoundToInt (Random.Range (1, 3))];
	}
	
	public Sprite GetSprites() {
		return questions[];
	}

	public string GetQuestions() {

	}

	public string GetAnswer() {
		return answer;
	}
}
