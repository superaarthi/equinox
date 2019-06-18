using UnityEngine;
using System.Collections;

public class InventoryItem : MonoBehaviour {
	
	private bool isIn;
	public bool hasItem;
	//InventoryLog logNo;

	// Use this for initialization
	void Awake () {
		isIn = false;
		hasItem = false;

		//logNo = GameObject.Find ("Main Camera").GetComponent<InventoryLog>(); //If you don't want each object to have a preset space in the list
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			isIn = true;
				}
		if (Input.GetKeyUp (KeyCode.Z)) {
			isIn = false;
				}


	}



	void OnTriggerStay (Collider other) {
		if (isIn && !hasItem) {

			Destroy(gameObject);
			hasItem = true;
			//logNo.logInd++;
		}

	}
		
	public bool ReportItem() {
			return hasItem;
		}



}
