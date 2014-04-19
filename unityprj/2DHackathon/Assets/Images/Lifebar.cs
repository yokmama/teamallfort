using UnityEngine;
using System.Collections;

public class Lifebar : MonoBehaviour {

	public GUIStyle style1;
	public GUIStyle style2;
	public GUIStyle fontStyle;
	public int MAXPOINT = 1000;

	private GameControl gameControler = null; 

	void Start(){
		gameControler = this.GetComponent<GameControl>();
	}
	
	void OnGUI () {
		float currentLife1 = gameControler.PtKinoko>0 ? gameControler.PtKinoko/(float)MAXPOINT : 0;
		float currentLife2 = gameControler.PtTakenoko>0 ? gameControler.PtTakenoko/(float)MAXPOINT : 0;
		
		float centerX = Screen.width / 2;

		float width = centerX;
		float height = 10f;
		float width1 = width * currentLife1;
		float width2 = width * currentLife2;

		GUI.Box(new Rect(10f, 10f, width1, height), "", style1);
		GUI.Box(new Rect(Screen.width-10-width2,  10f, width2, height), "", style2);

		string score = gameControler.PtKinoko + "/" + gameControler.PtTakenoko;
		GUI.Label (new Rect (Screen.width/2-50, 20, 100, 50), score, fontStyle);

	}

}
