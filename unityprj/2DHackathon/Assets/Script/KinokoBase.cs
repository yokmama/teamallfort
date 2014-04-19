using UnityEngine;
using System.Collections;

public class KinokoBase : MonoBehaviour {
	public float speed;
	public float power;
	
	public enum Team{
		Kinoko,
		Takenoko
	}
	public Team team = Team.Kinoko;
	protected GameObject kohaku;
	void Start () {
		kohaku = GameObject.FindGameObjectWithTag("Kohaku");
		animator = this.GetComponent<Animator>();
		setAnim(Anim.Walk);
	}

	private Animator animator;
	public enum Anim{
		Wait,
		Walk,
		Pull,
		Atk,
		Dmg
	}
	protected void setAnim(KinokoBase.Anim anim){
		switch(anim){
		case Anim.Wait:
			animator.SetTrigger("Wait");
			break;
		case Anim.Walk:
			animator.SetTrigger("Walk");
			break;
		case Anim.Pull:
			animator.SetTrigger("Pull");
			break;
		case Anim.Atk:
			animator.SetTrigger("Atk");
			break;
		case Anim.Dmg:
			animator.SetTrigger("Dmg");
			break;
		}
	}

}
