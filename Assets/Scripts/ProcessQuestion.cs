using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProcessQuestion : MonoBehaviour {

	public SpriteRenderer render;
	public ScoreController score;

	private Question currentQuestion;
	private int[] questionList;
	private int index;

	void Start () {
		index = 0;
		questionList = shuffle ();
		currentQuestion = new Question(index);
		shuffle ();
	}

	void Update () {
		render.sprite = currentQuestion.GetSprite ();
	}

	public void TestAnswer(string input) {
		if (input.ToLower().Replace(" ", "" ) == currentQuestion.GetAnswer()) {
			currentQuestion = new Question(++index);
			score.UpdateScore(true);
		}else {
			score.UpdateScore(false);
		}
		
	}

	private int[] shuffle() {
		int[] array = new int[34];

		for(int i = 0; i < array.Length; i++) {
			array[i] = i;
		}

		int m = array.Length;

		while(m > 0) {
			int i = Random.Range(0, m--);
			int t = array[m];
			array[m] = array[i];
			array[i] = t;
		}

		return array;
	}
}
