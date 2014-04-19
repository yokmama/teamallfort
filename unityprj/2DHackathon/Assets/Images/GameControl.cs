using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public int ptKinoko;
	public int PtKinoko{
		set{
			ptKinoko = value;
		}
		get{
			return ptKinoko;
		}
	}
	public int ptTakenoko;
	public int PtTakenoko{
		set{
			ptTakenoko = value;
		}
		get{
			return ptTakenoko;
		}
	}

	private float timeCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;
		if (timeCounter > 1) {
			ptKinoko+=10;
			ptTakenoko+=10;
			timeCounter=0;
		}
	}
}
