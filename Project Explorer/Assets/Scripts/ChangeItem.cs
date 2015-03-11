using UnityEngine;
using System.Collections;

public class ChangeItem : MonoBehaviour {

	public GameObject[] items;

	int currentItemIndex;

	int numberOfItems = 0;



	// Use this for initialization
	void Start () {
	
		currentItemIndex = 10;

		foreach (GameObject go in items) {
			numberOfItems++;		
		}

		print (numberOfItems);



	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			selectItem(0);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			selectItem(1);	
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			selectItem(2);	
		}
	}

	void selectItem(int index){
		if (currentItemIndex == index) {
			items [index].SetActive (false);
			currentItemIndex = 10;
		} else {
			foreach (GameObject item in items)
				item.SetActive (false);
	
			items [index].SetActive (true);
			currentItemIndex = index;
		}
	}

	public GameObject[] getItems(){
		return items;
	}

	public GameObject getActiveObject(){
		foreach (GameObject go in items) {
			if(go.activeSelf){
				return go;
			}
		}
		return null;
	}
	
}
