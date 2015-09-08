using UnityEngine;
using System.Collections;

public class ButtonListener : MonoBehaviour {

	public void SwitchScene(int value) {
		switch (value) {
		case 0:
			Application.LoadLevel (0); 
			break;
		
		case 1: 
			Application.LoadLevel (1); 
			break;
		
		case 2: 
			Application.LoadLevel (1); 
			DifficultySetting.instance.setEasy(false);
			break;

		case 3:
			Application.LoadLevel (2); 
			break;

		default:
			break;
		}
	}

	public void QuitGame() {
		Application.Quit ();
	}

}
