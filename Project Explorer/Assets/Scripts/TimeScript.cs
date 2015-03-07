using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {

	public int	currentHour = 0;
	public int currentMinute = 0;
	public int currentSecond = 0;

	public float speedOfTime;

	float elapsedTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		elapsedTime += Time.deltaTime;
		if(elapsedTime > speedOfTime){
			addSecond();
			elapsedTime = 0;
			//print(printTime ());
		}


		if(Input.GetKeyDown(KeyCode.U)){
			if(++currentHour == 24)
				currentHour = 0;
		}
		if(Input.GetKeyDown(KeyCode.I)){
			if(--currentHour == -1){
				currentHour = 23;
			}
		}



	}

	void addSecond(){
		if (++currentSecond == 60) {
			currentSecond = 0;
			addMinute();
		}
	}
	void addMinute(){
		if (++currentMinute == 60) {
			currentMinute = 0;
			addHour();
		}
	}
	void addHour(){
		if (++currentHour == 24) {
			currentHour = 0;
		}
	}

	//SET TIME
	void setTime(int second, int minute, int hour){
		currentSecond = second;
		currentMinute = minute;
		currentHour = hour;
	}

	void setSecond(int second){
		currentHour = second;
	}
	void setMinute(int minute){
		currentMinute = minute;
	}
	void setHour(int hour){
		currentHour = hour;
	}
	//PRINT TIME
	string printTime(){
		return printHour () + ":" + printMinute () + ":" + printSecond ();
	}

	string printSecond(){
		if (currentSecond >= 10)
			return currentSecond.ToString ();
		else
			return "0" + currentSecond.ToString ();
	}
	string printMinute(){
		if (currentMinute >= 10)
			return currentMinute.ToString ();
		else
			return "0" + currentMinute.ToString ();
	}
	string printHour(){
		if (currentHour >= 10)
			return currentHour.ToString ();
		else
			return "0" + currentHour.ToString ();
	}

	//GET
	public int getCurrentSecond(){
		return currentSecond;
	}

	public int getCurrentMinute(){
		return currentMinute;
	}

	public int getCurrentHour(){
		return currentHour;
	}
}
