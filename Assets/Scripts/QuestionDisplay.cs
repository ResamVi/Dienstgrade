using UnityEngine;
using System.Collections;

public class QuestionDisplay : MonoBehaviour {

	public Sprite[] list;

	void Start () {
	
		list = Resources.LoadAll <Sprite>("Sprites");

		int number = (int)Random.Range (0, 33);

		for(int i = 0; i < list.Length; i++) {
			Debug.Log (list[i]);
		}

		//Sprite picture = QuestionDatabase.instance.getQuestion ( number );

		GetComponent<SpriteRenderer> ().sprite = list [number];

	}

	void Update () {
	
	}
}
