using UnityEngine;
using System.Collections;

public class OrbitCycle : MonoBehaviour {

	TimeScript ts;

	Vector3 max = new Vector3(360,0,0);
	Vector3 min = new Vector3(0,0,0);

	float sixtyMultiplier = 100 / 60;
	float hourMultiplier = 100 / 24;


	// Use this for initialization
	void Start () {
	
		ts = GameObject.Find ("Time").GetComponent<TimeScript> ();

	}
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles = Vector3.Slerp (min, max, setOrbit ());
	}


	float setOrbit(){
		return (0.01f * ts.getCurrentHour() * hourMultiplier) + (0.0001f * ts.getCurrentMinute() * sixtyMultiplier) + (0.000001f * ts.getCurrentSecond() * sixtyMultiplier);
	}


}
