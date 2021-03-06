﻿using UnityEngine;
using System.Collections;

public class PullKinokoScript : KinokoBase {

	public enum State{
		Approach,
		Pull
	}
	private State state = State.Approach;
	public void SetState(State st){
		switch(st){
		case State.Approach:
			setAnim(Anim.Walk);
			break;
		case State.Pull:
			setAnim(Anim.Pull);
			this.rigidbody2D.velocity = Vector2.zero;
			break;
		}
		state = st;
	}
	public override void RecoverDmg(){
		switch(state){
		case State.Approach:
			setAnim(Anim.Walk);
			break;
		case State.Pull:
			setAnim(Anim.Pull);
			break;
		}
	}

	private GameObject kohaku;
	void Start () {
		kohaku = GameObject.FindGameObjectWithTag("Kohaku");
		animator = this.GetComponent<Animator>();
		setAnim(Anim.Walk);
	}

	// Update is called once per frame
	void LateUpdate () {
		switch(state){
		case State.Approach:
			Vector2 delta = new Vector2(kohaku.transform.position.x, kohaku.transform.position.y)
				- new Vector2(this.transform.position.x,this.transform.position.y);
			if(delta.magnitude > 0.1f){
				switch(team){
				case Team.Kinoko:
					this.rigidbody2D.velocity = Vector2.right * speed;
					break;
				case Team.Takenoko:
					this.rigidbody2D.velocity = -Vector2.right * speed;
					break;
				}
			}else{
				this.rigidbody2D.velocity = Vector2.zero;
			}
			break;
		case State.Pull:
			switch(team){
			case Team.Kinoko:
				kohaku.rigidbody2D.velocity += -Vector2.right * power;
				break;
			case Team.Takenoko:
				kohaku.rigidbody2D.velocity += Vector2.right * power;
				break;
			}
			break;
		}
	}	
}
