using UnityEngine;
using System.Collections;

public class BtnScript : MonoBehaviour {
	public KinokoBase.Team team;
	public GameObject chara;
	public Transform spawner;
	public void OnPressed(){
		Debug.Log (this.name + " Pressed");
		Vector3 pos = spawner.position;
		pos.z = 0;
		KinokoBase kinoko = ((GameObject)Instantiate(chara,pos,
		                  Quaternion.identity)).GetComponent<KinokoBase>();
		kinoko.team = team;
	}
}
