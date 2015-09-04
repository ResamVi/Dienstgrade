using UnityEngine;
using System.Collections;

public class DifficultySetting : MonoBehaviour
{
	private bool easy = true;

	private static DifficultySetting _instance;
	public static DifficultySetting instance
	{
		get
		{
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType<DifficultySetting> ();

				DontDestroyOnLoad (_instance.gameObject);
			}
		
			return _instance;
		}
	}

	void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad (this);
		} 
		else 
		{
			if(this != _instance)
				Destroy(this.gameObject);
		}
	
	}

	public void setEasy(bool easy) {
		this.easy = easy;
	}

	public bool isEasy() {
		return easy;
	}

}
