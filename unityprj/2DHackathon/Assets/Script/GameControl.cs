using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	private int ptKinoko =1000;
	public int PtKinoko{
		set{
			ptKinoko = Mathf.Clamp(value,0,1000);
		}
		get{
			return ptKinoko;
		}
	}
	private int ptTakenoko = 1000;
	public int PtTakenoko{
		set{
			ptTakenoko = Mathf.Clamp(value,0,1000);
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
