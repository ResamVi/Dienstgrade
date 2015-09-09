﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProcessQuestion : MonoBehaviour {

	public SpriteRenderer render;
	public ScoreController score;

	public Object correct;
	public Object wrong;

	private Question currentQuestion;
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

		currentQuestion = new Question(questionList[index]);
		shuffle ();
		Debug.Log (difficult);
	}

	void Update () {
		render.sprite = currentQuestion.GetSprite ();
	}

	public void TestAnswer(string input) {
		if (input.ToLower().Replace(" ", "" ) == currentQuestion.GetAnswer()) {
			currentQuestion = new Question(questionList[++index]);
			Instantiate (correct, new Vector2(0,0), Quaternion.identity);
			score.UpdateScore(true);

		}else {
			score.UpdateScore(false);
			Instantiate (wrong, new Vector2(0,0), Quaternion.identity);
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
