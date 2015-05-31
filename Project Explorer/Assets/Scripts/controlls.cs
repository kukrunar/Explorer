using UnityEngine;
using System.Collections;

public class controlls : MonoBehaviour {

	public float speed;
	public float mouseSensetiveness;
	float step;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		step = speed * Time.deltaTime;


		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector3.forward * step);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(-Vector3.forward * step);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-Vector3.right * step);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector3.right * step);
		}

		transform.Rotate (0, Input.GetAxisRaw("Mouse X") * mouseSensetiveness * Time.deltaTime, 0);
		transform.Rotate (-Input.GetAxisRaw ("Mouse Y") * mouseSensetiveness * Time.deltaTime, 0, 0);


	}
}
