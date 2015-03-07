using UnityEngine;
using System.Collections;

public class GlobeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.F)){
			GetComponent<Rigidbody>().AddTorque(Vector3.up * 50 * Time.deltaTime);
		}


	}
}
