using UnityEngine;
using System.Collections;

public class KeyboardInputs : MonoBehaviour {
	
	KeyCode forward = KeyCode.W;
	KeyCode backward = KeyCode.S;
	KeyCode leftward = KeyCode.A;
	KeyCode rightward = KeyCode.D;

	int speed = 1000;

	PickupObject po;
	


	// Use this for initialization
	void Start () {
	
		po = GetComponent<PickupObject> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (forward)) {
			GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (backward)) {
			GetComponent<Rigidbody>().AddForce(-transform.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (leftward)) {
			GetComponent<Rigidbody>().AddForce(-transform.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (rightward)) {
			GetComponent<Rigidbody>().AddForce(transform.right * speed * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			po.pickup();
		}

	}
}
