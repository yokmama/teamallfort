using UnityEngine;
using System.Collections;

public class InputControl : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray r = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(r,out hit)){
				if("Btn".Equals(hit.transform.tag)){
					hit.transform.gameObject.SendMessage("OnPressed");
				}
			}
		}
	}
}
