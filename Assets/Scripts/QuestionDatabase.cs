using UnityEngine;
using System.Collections;

public class QuestionDatabase : MonoBehaviour {

	public static QuestionDatabase instance { get; private set; }
	private string[] answer;

	void Awake() {
		instance = this;
		
		// Answers
		answer = new string[33];
		
		answer [0] = "Gefreiter";
		answer [1] = "Obergefreiter";
		answer [2] = "Hauptgefreiter";
		answer [3] = "Stabsgefreiter";
		answer [4] = "Oberstabsgefreiter";
		answer [5] = "Schütze (UA)";
		answer [6] = "Gefreiter (UA)";
		answer [7] = "Obergefreiter (UA)";
		answer [8] = "Hauptgefreiter (UA)";
		answer [9] = "Gefreiter (FA)";
		answer [10] = "Gefreiter (OA)";
		answer [11] = "Unteroffizier";
		answer [12] = "Stabsunteroffizier";
		answer [13] = "Feldwebel";
		answer [14] = "Oberfeldwebel";
		answer [15] = "Hauptfeldwebel";
		answer [16] = "Stabsfeldwebel";
		answer [17] = "Oberstabsfeldwebel";
		answer [18] = "Unteroffizier (FA)";
		answer [19] = "Fahnenjunker";
		answer [20] = "Fähnrich";
		answer [21] = "Oberfähnrich";
		answer [22] = "Leutnant";
		answer [23] = "Oberleutnant";
		answer [24] = "Hauptmann";
		answer [25] = "Stabshauptmann";
		answer [26] = "Major";
		answer [27] = "Oberstleutnant";
		answer [28] = "Oberst";
		answer [29] = "Brigadegeneral";
		answer [30] = "Generalmajor";
		answer [31] = "Generalleutnant";
		answer [32] = "General";

	}

	public string getAnswer(int index) {
		if(index >= 0 && index <= 32)
			return answer[index];
		else
			return "Error";
	}
}
