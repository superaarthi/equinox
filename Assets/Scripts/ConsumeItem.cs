using UnityEngine;
using System.Collections;

public class ConsumeItem : MonoBehaviour {

	private InventoryItem item;
	private bool isUse;
	bool itemYes;
	public string ItemName;
    public SpriteRenderer openDoor;
	
	// Use this for initialization
	void Awake () {
		item = GameObject.Find (ItemName).GetComponent<InventoryItem>();
		isUse = false;
	}
	
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			isUse = true;
		}
		if (Input.GetKeyUp (KeyCode.Z)) {
			isUse = false;
		}
		
		
		itemYes = item.ReportItem();
		
	}
	
	void OnCollisionStay (Collision other) {
		if (isUse && itemYes) {
            openDoor.enabled = true;
            item.hasItem = false;
			Destroy (gameObject);
		}
	}
}
