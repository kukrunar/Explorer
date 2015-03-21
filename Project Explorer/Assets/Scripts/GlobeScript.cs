using UnityEngine;
using System.Collections;

public class GlobeScript : MonoBehaviour, IInteractable {

	public bool open;
	bool wasOpen;


	public GameObject holder;
	public GameObject topGlobe;

	Quaternion closedVec;
	Quaternion openVec;

	float speed = 100.0f;
	float step;


	// Use this for initialization
	void Start () {
		open = false;

		closedVec = Quaternion.Euler (holder.transform.eulerAngles);
		openVec = Quaternion.Euler (new Vector3 (holder.transform.eulerAngles.x - 70, holder.transform.eulerAngles.y, holder.transform.eulerAngles.z));
	}
	
	// Update is called once per frame
	void Update () {

		step = speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.F)) {
			toggleOpen();		
		}

		if (open) {
			holder.transform.rotation = Quaternion.RotateTowards(holder.transform.rotation,openVec,step);
		}
		else
			holder.transform.rotation = Quaternion.RotateTowards(holder.transform.rotation,closedVec,step);

		if (holder.transform.rotation == closedVec && wasOpen) {
			topGlobe.transform.parent = this.transform;
			wasOpen = false;
		}


	}

	public void interact(){
		if(!open)
			GetComponent<Rigidbody>().AddTorque(Vector3.up * 200 * Time.deltaTime);
	}

	void toggleOpen(){
		open = !open;

		if (open) {
			topGlobe.transform.parent = holder.transform;
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, 0);
		} else
			wasOpen = true;

	}
}
