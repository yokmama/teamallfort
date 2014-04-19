using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	private int ptKinoko;
	public int PtKinoko{
		set{
			ptKinoko = value;
		}
		get{
			return ptKinoko;
		}
	}
	private int ptTakenoko;
	public int PtTakenoko{
		set{
			ptTakenoko = value;
		}
		get{
			return ptTakenoko;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
