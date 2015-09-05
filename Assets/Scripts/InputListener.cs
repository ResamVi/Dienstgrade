using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputListener : MonoBehaviour {

	public ProcessQuestion process;

	private string input;

	void Start() {
		InputField input = GameObject.Find ("HUD/InputField").GetComponent<InputField>();
		input.onEndEdit.AddListener (SubmitInput);
	}

	private void SubmitInput(string input) {
		process.TestAnswer (input);
	}

	public string GetInput() {
		return input;
	}
}
