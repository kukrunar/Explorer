using UnityEngine;
using System.Collections;

public class CompasScript : MonoBehaviour {

	public GameObject np;
	public GameObject nDir;
	GameObject north;
	Vector3 northPos;

	float maxWiggle = 50.0f;
	float minWiggle = 20.0f;
	float dirWiggle = 1.0f;

	
	// Use this for initialization
	void Start () {
		north = GameObject.Find ("North");
		northPos = new Vector3 (north.transform.position.x, transform.position.y, north.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		northPos.y = transform.position.y;

		nDir.transform.LookAt (northPos);

		np.transform.localEulerAngles = new Vector3(0, nDir.transform.localEulerAngles.y, 0);

		//pointWiggle ();

	}

	void pointWiggle(){
		np.transform.Rotate (0, Random.Range (minWiggle, maxWiggle) * dirWiggle * Time.deltaTime, 0);
		dirWiggle *= -1;

	}


}
