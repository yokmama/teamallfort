using UnityEngine;
using System.Collections;

public class ClearAreaScript : MonoBehaviour {

	public KinokoBase.Team team;
	void OnTriggerEnter2D(Collider2D col){
		if("Kohaku".Equals(col.tag)){
			switch(team){
			case KinokoBase.Team.Kinoko:
				Application.LoadLevel("ClearSceneKinoko");
				break;
			case KinokoBase.Team.Takenoko:
				Application.LoadLevel("ClearSceneTakenoko");
				break;
			}
		}
	}

}
