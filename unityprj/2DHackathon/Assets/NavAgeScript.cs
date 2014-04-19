using UnityEngine;
using System.Collections;

public class NavAgeScript : MonoBehaviour {
	NavMeshAgent age;
	// Use this for initialization
	void Start () {
		age = this.GetComponent<NavMeshAgent>();
		age.SetDestination(new Vector3(-5,0,0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
