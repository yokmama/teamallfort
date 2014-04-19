using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	private Vector3 defPos;
	// Use this for initialization
	void Start () {
		defPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = defPos + Vector3.up * Mathf.Sin(Time.time) * 3
			+ Vector3.right * Mathf.Sin(Time.time * 6) * 0.5f;
	}
}
