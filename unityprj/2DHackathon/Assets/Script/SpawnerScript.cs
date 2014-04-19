﻿using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	private Vector3 defPos;
	// Use this for initialization
	void Start () {
		defPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = defPos + Vector3.up * Mathf.Sin(Time.time * 2) * 4;
	}
}