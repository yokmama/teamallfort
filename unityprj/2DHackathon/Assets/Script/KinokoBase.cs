using UnityEngine;
using System.Collections;

public class KinokoBase : MonoBehaviour {
	public float speed;
	public float power;
	public float life;

	private int index;

	public enum Team{
		Kinoko,
		Takenoko
	}
	public Team team = Team.Kinoko;

	protected Animator animator;
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
	public void GetDamage(int dmg){
		setAnim(Anim.Dmg);
		Invoke("RecoverDmg",1.5f);
	}
	public virtual void RecoverDmg(){}

}
