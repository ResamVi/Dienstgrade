using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputListener : MonoBehaviour {

	public ProcessQuestion process;
	InputField field;

	void Start() {
		field = GameObject.Find ("HUD/InputField").GetComponent<InputField>();
		field.onEndEdit.AddListener (SubmitInput);
	}

	private void SubmitInput(string input) {
		process.TestAnswer (input);
		field.text = "";
	}
}
