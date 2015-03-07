using UnityEngine;
using System.Collections;

public class CameraRotaiton : MonoBehaviour {

	GameObject head;
	public int mouseSensetiveness;

	// Use this for initialization
	void Start () {
	
		head = GameObject.Find ("Body/Head");

	}
	
	// Update is called once per frame
	void Update () {
	
		head.transform.Rotate(-Input.GetAxisRaw("Mouse Y") * mouseSensetiveness * Time.deltaTime, 0, 0);
		transform.Rotate (0, Input.GetAxisRaw("Mouse X") * mouseSensetiveness * Time.deltaTime, 0);

	}

	public void setMouseSensetiveness(int value){
		mouseSensetiveness = value;
	}
}
