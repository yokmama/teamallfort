using UnityEngine;
using System.Collections;

public class ClearScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Next",5.0f);
	}

	public void Next(){
		Application.LoadLevel("TopScene");
	}
}
