using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AllKinokoControll : MonoBehaviour {
	public Dictionary<int,KinokoBase> kinokos;
	private int index = 0;
	// Use this for initialization
	void Start () {
		kinokos = new Dictionary<int,KinokoBase>();
	}

	public int AddKinoko(KinokoBase kinoko){
		kinokos.Add(index++,kinoko);
		return index;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
