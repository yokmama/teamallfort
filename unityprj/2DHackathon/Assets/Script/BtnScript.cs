using UnityEngine;
using System.Collections;

public class BtnScript : MonoBehaviour {
	public KinokoBase.Team team;
	public GameObject chara;
	public int point;
	public Transform spawner;

	private GameControl control;
	void Start(){
		control = GameObject.FindGameObjectWithTag("Controls").GetComponent<GameControl>();
	}
	public void OnPressed(){
		Debug.Log (this.name + " Pressed");

		switch(team){
		case KinokoBase.Team.Kinoko:
			if(point > control.PtKinoko){
				return;
			}else{
				control.PtKinoko -= point;
			}
			break;
		case KinokoBase.Team.Takenoko:
			if(point > control.PtTakenoko){
				return;
			}else{
				control.PtTakenoko -= point;
			}
			break;
		}
		Vector3 pos = spawner.position;
		pos.z = -2;
		KinokoBase kinoko = ((GameObject)Instantiate(chara,pos,
		                  Quaternion.identity)).GetComponent<KinokoBase>();
		if(team == KinokoBase.Team.Takenoko){
			kinoko.transform.rotation = Quaternion.Euler(0,180,0);
		}
		kinoko.team = team;
	}
}
