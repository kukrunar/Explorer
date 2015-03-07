using UnityEngine;
using System.Collections;

public class ClockScript : MonoBehaviour {

	public GameObject hourPointer;
	public GameObject minutePointer;
	public GameObject secondPointer;

	Vector3 min = new Vector3(0,0,0);
	Vector3 max = new Vector3(0,360,0);

	float sixtyCounter = 1.0f / 60.0f;
	float hourCounter = 1.0f / 12.0f;

	int currentHour;

	TimeScript ts;



	// Use this for initialization
	void Start () {
		//hourPointer = GameObject.Find ("ClockPanel/hourPointer");
		//minutePointer = GameObject.Find ("ClockPanel/minutePointer");
		//secondPointer = GameObject.Find ("ClockPanel/secondPointer");

		ts = GameObject.Find ("Time").GetComponent<TimeScript> ();

		currentHour = ts.getCurrentHour ();
	}
	
	// Update is called once per frame
	void Update () {
	
		hourPointer.transform.localEulerAngles = Vector3.Slerp(min, max, getHourCounter());
		minutePointer.transform.localEulerAngles = Vector3.Slerp (min, max, getMinuteCounter());
		secondPointer.transform.localEulerAngles = Vector3.Slerp (min, max, getSecondCounter());


	}

	float getSecondCounter(){
		return ts.getCurrentSecond() * sixtyCounter;
	}

	float getMinuteCounter(){
		return ts.getCurrentMinute() * sixtyCounter;
	}

	float getHourCounter(){
		currentHour = ts.getCurrentHour ();
		if (currentHour > 12)
			currentHour -= 12;
		return  currentHour * hourCounter;
	}
}
