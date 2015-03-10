using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	GameObject cam;
	GameObject carriedObject;

	public LayerMask pickupable;

	bool carrying;

	Ray ray;
	RaycastHit hit;


	// Use this for initialization
	void Start () {
	
		cam = GameObject.FindWithTag("MainCamera");

	}
	
	// Update is called once per frame
	void Update () {
	
		if (carrying) {
			carry();
		}

	}

	void carry(){
		carriedObject.transform.position = cam.transform.position + (cam.transform.forward * 1);
	}


	public void pickup(GameObject obj){

		if (carrying) {
			dropObject ();
		} else {
			carriedObject = obj;
			carrying = true;
			carriedObject.GetComponent<Rigidbody> ().useGravity = false;
			print (carriedObject);

		}

	}

	public void dropObject(){
		carriedObject.GetComponent<Rigidbody> ().useGravity = true;
		carriedObject = null;
		carrying = false;
	}



}
