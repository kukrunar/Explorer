using UnityEngine;
using System.Collections;

public class MouseInputs : MonoBehaviour {

	PickupObject po;
	ChangeItem ci;


	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		po = GetComponent<PickupObject> ();
		ci = transform.FindChild ("Items").GetComponent<ChangeItem> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetMouseButtonDown (0)) {
			po.pickup();		
		}
		if (Input.GetMouseButtonDown (1)) {
			IUseable activeItem = (IUseable)ci.getActiveObject().GetComponent(typeof(IUseable));
			if(activeItem != null)
				activeItem.use ();

		}


	}
}
