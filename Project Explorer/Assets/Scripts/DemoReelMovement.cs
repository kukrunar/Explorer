using UnityEngine;
using System.Collections;

public class DemoReelMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 trans = Vector3.zero;
		if(Input.GetKey(KeyCode.W)){
			trans += transform.forward*speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S)){
			trans -= transform.forward*speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A)){
			trans -= transform.right*speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)){
			trans += transform.right*speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.Q)){
			trans -= transform.up*speed*Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.E)){
			trans += transform.up*speed*Time.deltaTime;
		}
	
		transform.position += (trans);
	}
}
