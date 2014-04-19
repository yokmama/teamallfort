using UnityEngine;
using System.Collections;

public class InputControl : MonoBehaviour {
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
		if(Input.GetMouseButtonDown(0)){
			Ray r = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(r,out hit)){
				if("Btn".Equals(hit.transform.tag)){
					hit.transform.gameObject.SendMessage("OnPressed");
				}
			}
		}
#elif UNITY_ANDROID || UNITY_IPHONE
		for(int i = 0; i < Input.touchCount; i++){
			if(TouchPhase.Began == Input.GetTouch(i).phase){
				Ray r = camera.ScreenPointToRay(Input.GetTouch(i).position;
				RaycastHit hit;
				if(Physics.Raycast(r,out hit)){
					if("Btn".Equals(hit.transform.tag)){
						hit.transform.gameObject.SendMessage("OnPressed");
					}
				}
			}
		}
#endif
	}
}
