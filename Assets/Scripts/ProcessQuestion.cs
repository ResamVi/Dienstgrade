using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProcessQuestion : MonoBehaviour {

	public SpriteRenderer render;
	public ScoreController score;

	public Object correct;
	public Object wrong;

	private QuestionPicture currentQuestion;
	private int[] questionList;
	private int index;
	private bool difficult;

	void Start () {
		index = 0;
		questionList = shuffle ();

		if (GameObject.Find ("H_Difficulty") != null)
			difficult = true;
		else
			difficult = false;

		currentQuestion = new QuestionPicture(questionList[index]);
		shuffle ();
	}

	void Update () {
		render.sprite = currentQuestion.GetSprite ();
	}

	public void TestAnswer(string input) {
		if (input.ToLower().Replace(" ", "" ) == currentQuestion.GetAnswer()) {
			createQuestion();

		}else {
			score.UpdateScore(false);
			Instantiate (wrong, new Vector2(0,0), Quaternion.identity);
		}
		
	}

	private int[] shuffle() {
		int[] array = new int[33];

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

	private void createQuestion() {
		if (!difficult) {
			currentQuestion = new QuestionPicture (questionList [index]);
			Instantiate (correct, new Vector2 (0, 0), Quaternion.identity);
			score.UpdateScore (true);
		}else {
			if(Mathf.Round(Random.value) == 0) {
				currentQuestion = new QuestionPicture (questionList [index]);
				Instantiate (correct, new Vector2 (0, 0), Quaternion.identity);
				score.UpdateScore (true);
			}else{
				// Other variation
			}
		}
	}
}
