using UnityEngine;
using System.Collections;

public class TopScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Next",3.0f);
	}

	public void Next(){
		Application.LoadLevel("GameScene");
	}
}
