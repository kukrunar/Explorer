using UnityEngine;
using System.Collections;

public class FlashlightScript : MonoBehaviour, IUseable {

	GameObject cam;

	Ray ray;
	RaycastHit hit;
	public LayerMask lm;
	bool lightOn;
	Light light;

	// Use this for initialization
	void Start () {

		lightOn = true;
		cam = GameObject.FindWithTag ("MainCamera");

		light = transform.FindChild ("Light").GetComponent<Light> ();
		light.enabled = lightOn;


	}
	
	// Update is called once per frame
	void Update () {
	
		ray = new Ray (cam.transform.position, cam.transform.forward);

		//if(Physics.Raycast(ray, out hit)){
		//transform.LookAt(hit.point);
			transform.localEulerAngles = new Vector3(-cam.transform.eulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
		//}


	}

	public void toggleLight(){
		light.enabled = !light.enabled;
	}

	public void use(){
		toggleLight ();
	}
}
