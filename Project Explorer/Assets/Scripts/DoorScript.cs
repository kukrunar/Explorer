using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {


	Quaternion closedValue;
	Quaternion openValue;

	Vector3 newDir;

	public bool open;
	public bool locked;

	float speed = 100.0f;
	float step;


	// Use this for initialization
	void Start () {
	
		open = false;

		closedValue = Quaternion.Euler(transform.eulerAngles);
		openValue = Quaternion.Euler(new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y + 90, transform.localEulerAngles.z));


	}
	
	// Update is called once per frame
	void Update () {

		step = speed * Time.deltaTime;
		if (open) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, openValue, step);
		} else {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, closedValue, step);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if(!locked){
				toggleOpen ();
			}
		}
	}

	void toggleOpen(){
		open = !open;
	}
	void toggleLocked(){
		locked = !locked;
	}


}
