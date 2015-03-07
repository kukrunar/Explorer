using UnityEngine;
using System.Collections;

public class ArmMovement : MonoBehaviour {

	Vector3 standardRotation = new Vector3(0,0,0);
	Vector3 standardPosition = new Vector3(0.6f, 0.05f, -0.02f);

	Vector3 liftRotation = new Vector3(-77, -180, 156);
	Vector3 liftPosition = new Vector3(0.4f, 0.5f, 0.4f);

	float speed = 1.0f;
	float step;

	bool moveToStandard;

	// Use this for initialization
	void Start () {
	
		moveToStandard = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		step = speed * Time.deltaTime;
		moveArm ();

	}

	void moveArm(){

		if (!moveToStandard) {
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, liftPosition, step);
			transform.localEulerAngles = Vector3.RotateTowards (transform.localEulerAngles, liftRotation, step, 0.0f);
		} else {
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, standardPosition, step);
			transform.localEulerAngles = Vector3.RotateTowards (transform.localEulerAngles, standardRotation, step, 0.0f);
		}

	}



}
