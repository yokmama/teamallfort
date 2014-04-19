using UnityEngine;
using System.Collections;

public class AttackKinokoScript : KinokoBase {
	public enum State{
		Approach,
		Attack
	}
	private State state = State.Approach;
	public void SetState(State st){
		switch(st){
		case State.Approach:
			setAnim(Anim.Walk);
			break;
		case State.Attack:
			setAnim(Anim.Atk);
			this.rigidbody2D.velocity = Vector2.zero;
			break;
		}
		state = st;
	}

	private Vector3 distPoint;
	private AllKinokoControll kControl;
	void Start(){
		kControl = GameObject.FindGameObjectWithTag("Controls").GetComponent<AllKinokoControll>();
		animator = this.GetComponent<Animator>();
		setAnim(Anim.Walk);
			if(this.transform.position.y > 0){
			distPoint = new Vector3(0,3);
		}else{
			distPoint = new Vector3(0,-3);
		}
	}

	void LateUpdate () {
		switch(state){
		case State.Approach:
			Vector2 delta = new Vector2(distPoint.x, distPoint.y)
				- new Vector2(this.transform.position.x,this.transform.position.y);
			if(delta.magnitude > 0.1f){
				this.rigidbody2D.velocity = delta.normalized * speed;
			}else{
//Seach
				this.rigidbody2D.velocity = Vector2.zero;
			}
			break;
		case State.Attack:
			break;
		}
	}

}
