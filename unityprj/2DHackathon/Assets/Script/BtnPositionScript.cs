using UnityEngine;
using System.Collections;

public class BtnPositionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float asp = Camera.main.aspect;
		Vector3 pos = this.transform.localPosition;
		pos.x *= asp;
		this.transform.localPosition = pos;
		Destroy(this);
	}

}
