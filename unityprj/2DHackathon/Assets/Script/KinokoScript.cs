using UnityEngine;
using System.Collections;

public class KinokoScript : MonoBehaviour {
	public float speed;
	public float power;
	public Vector2 ditnationPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 delta = ditnationPoint
			- new Vector2(this.transform.position.x,this.transform.position.y);
		if(delta.magnitude > 0.1f){
			this.rigidbody2D.velocity = delta.normalized * speed;
		}else{
			this.rigidbody2D.velocity = Vector2.zero;
		}
	}
}
