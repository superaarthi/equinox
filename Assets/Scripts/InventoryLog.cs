using UnityEngine;
using System.Collections;

public class InventoryLog : MonoBehaviour {

	//public float logInd = 0;
	private InventoryItem WateringCan;
	private bool hasWC;

	private InventoryItem Axe;
	private bool hasAxe;

	private InventoryItem Key;
	private bool hasKey;


	// Use this for initialization
	void Start () {
		WateringCan = GameObject.Find ("Watering can").GetComponent<InventoryItem>();
		Axe = GameObject.Find ("Axe").GetComponent <InventoryItem> ();
		Key = GameObject.Find ("Key").GetComponent <InventoryItem> ();
	
	}


	// Update is called once per frame
	void Update () {
		hasWC = WateringCan.ReportItem();
		hasAxe = Axe.ReportItem ();
		hasKey = Key.ReportItem ();
	}



	void OnGUI() {
		GUI.Box (new Rect (0, 0, 80, 30), "Items: ");
		if (hasWC) {
			GUI.Box (new Rect (0, 30, 90, 30), "Watering Can");
				}

		if (hasAxe) {
			GUI.Box (new Rect (0, 60, 90, 30), "Axe");
	}

		if (hasKey) {
			GUI.Box (new Rect(0,90,90,30), "Key");
		}
	
	
	}

}
