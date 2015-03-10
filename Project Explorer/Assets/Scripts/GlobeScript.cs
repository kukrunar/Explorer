using UnityEngine;
using System.Collections;

public class GlobeScript : MonoBehaviour, IInteractable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void interact(){
		GetComponent<Rigidbody>().AddTorque(Vector3.up * 200 * Time.deltaTime);
	}
}
