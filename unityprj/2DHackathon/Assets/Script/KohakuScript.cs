using UnityEngine;
using System.Collections;

public class KohakuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody2D.velocity = Vector2.zero;
	}

	void OnTriggerEnter2D(Collider2D col){
		if("CharacterPull".Equals(col.tag)){
			col.gameObject.SendMessage("SetState",PullKinokoScript.State.Pull);
			col.transform.parent = this.transform;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if("CharacterPull".Equals(col.tag)){
			col.gameObject.SendMessage("SetState",PullKinokoScript.State.Approach);
			col.transform.parent = null;
		}
	}
}
