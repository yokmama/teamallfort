using UnityEngine;
using System.Collections;

public class KohakuScript : MonoBehaviour {
	private UnityLive live;
	// Use this for initialization
	void Start () {
		live = this.GetComponentInChildren<UnityLive>();
	}
	
	// Update is called once per frame
	void Update () {
		live.xDegree = this.rigidbody2D.velocity.x * 100.0f;
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
