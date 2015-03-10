using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	GameObject cam;
	GameObject carriedObject;

	public LayerMask pickupable;
	public float distance;
	public float smooth;

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
		carriedObject.transform.position = Vector3.Lerp (carriedObject.transform.position, cam.transform.position + cam.transform.forward * distance, Time.deltaTime * smooth);//cam.transform.position + (cam.transform.forward * 1);
	}


	public void pickup(){

		if (carrying) {
			dropObject ();
		} else {
			ray = new Ray (cam.transform.position, cam.transform.forward);
			if (Physics.Raycast (ray, out hit, 1.5f, pickupable)) {
				carriedObject = hit.collider.gameObject;
				carrying = true;
				carriedObject.GetComponent<Rigidbody> ().useGravity = false;
				//print (carriedObject);
			}

		}

	}

	public void dropObject(){
		carriedObject.GetComponent<Rigidbody> ().useGravity = true;
		carriedObject = null;
		carrying = false;
	}


}
