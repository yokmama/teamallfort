using UnityEngine;
using System.Collections;

public class BtnScript : MonoBehaviour {
	public KinokoBase.Team team;
	public GameObject chara;
	public Transform spawner;
	public void OnPressed(){
		Debug.Log (this.name + " Pressed");
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
