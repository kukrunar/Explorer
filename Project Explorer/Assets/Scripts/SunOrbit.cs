using UnityEngine;
using System.Collections;

public class SunOrbit : MonoBehaviour {

	TimeScript ts;

	Vector3 min = new Vector3 (310, 0, 0);
	Vector3 max = new Vector3 (310, 0,360);


	float hourMultiplier = 100 / 23;
	float sixtyMultiplier = 100 / 59;


	// Use this for initialization
	void Start () {
	
		ts = GameObject.Find ("Time").GetComponent<TimeScript> ();

	}
	
	// Update is called once per frame
	void Update () {

		//transform.Rotate (0,step,0);

		transform.localEulerAngles = Vector3.Slerp (min, max, setOrbit());



	}

	float setOrbit(){

		return ((0.01f * (ts.getCurrentHour () * hourMultiplier)) + (0.0001f * (ts.getCurrentMinute() * sixtyMultiplier)) + (0.000001f * (ts.getCurrentSecond() * sixtyMultiplier)));

	}

	/*
	function Update () { 
		var dir = transform.forward; // get camera forward vector... 
		dir.y = 0; // but keep only the horizontal direction 
		var rot = Quaternion.LookRotation(dir); // now get the desired rotation 
		Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, rot, playerRotateSpeed * Time.deltaTime); 
	}
	*/


}
