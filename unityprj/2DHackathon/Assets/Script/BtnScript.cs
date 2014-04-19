using UnityEngine;
using System.Collections;

public class BtnScript : MonoBehaviour {
	public GameObject chara;
	public Transform spawner;
	public void OnPressed(){
		Debug.Log (this.name + " Pressed");
		Vector3 pos = spawner.position;
		pos.z = 0;
		Instantiate(chara,pos,Quaternion.identity);
	}
}
