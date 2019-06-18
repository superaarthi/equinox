using UnityEngine;
using System.Collections;

public class growTree : MonoBehaviour {

	private InventoryItem item;
	private GameObject platform1;
	private GameObject platform2;
	private GameObject platform3;
	private GameObject platform4;
	private GameObject platform5;
	bool itemYes;
	public string ItemName;

	// Use this for initialization
	void Start () {
	
	}

	// Use this for initialization
	void Awake () {
		item = GameObject.Find (ItemName).GetComponent<InventoryItem>();
		platform1 = GameObject.Find ("Leaf Platform 1");
		platform1.SetActive(false); 
		platform2 = GameObject.Find ("Leaf Platform 2");
		platform2.SetActive(false);
		platform3 = GameObject.Find ("Leaf Platform 3");
		platform3.SetActive(false);
		platform4 = GameObject.Find ("Leaf Platform 4");
		platform4.SetActive(false);
		platform5 = GameObject.Find ("Leaf Platform 5");
		platform5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		itemYes = item.ReportItem();
	}

	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.Z)) {
				if (itemYes) {
					GameObject.Find("icantdraw").GetComponent<SpriteRenderer>().enabled = true;
					platform1.SetActive(true); 
					platform2.SetActive(true);
					platform3.SetActive(true);
					platform4.SetActive(true);
					platform5.SetActive(true);
					Destroy(GameObject.Find ("clearly a standin"));
					Destroy(gameObject);
				}
			}
		}
	}

}
