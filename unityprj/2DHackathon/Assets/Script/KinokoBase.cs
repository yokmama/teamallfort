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
	}

}
