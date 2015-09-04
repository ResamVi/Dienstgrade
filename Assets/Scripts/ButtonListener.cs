using UnityEngine;
using System.Collections;

public class ButtonListener : MonoBehaviour {

	public void StartGame(bool isEasy) {
		if (isEasy)
			Application.LoadLevel (1);
	}

	public void QuitGame() {
		Application.Quit ();
	}

}
