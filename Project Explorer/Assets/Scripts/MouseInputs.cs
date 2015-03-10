using UnityEngine;
using System.Collections;

public class MouseInputs : MonoBehaviour {

	PickupObject po;


	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		po = GetComponent<PickupObject> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetMouseButtonDown (0)) {
			po.pickup();		
		}


	}
}
