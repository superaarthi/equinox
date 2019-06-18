using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
	
	public string PauseLocation;
	public string NextLevel;

	int width = Screen.width/3;
	int height = Screen.height/4;
	int xloc; 
	int yloc;

	//private PauseMenu Paused;
	public bool isPortal;
	private float scale;
	// Use this for initialization
	void Start () {


		//Paused = GameObject.Find (PauseLocation).GetComponent<PauseMenu>();
	
		isPortal = false;
		scale = Time.timeScale;

		xloc = Screen.width/2 - width/2;
		yloc = Screen.height/2 - 2*height/3;

	}
	
	// Update is called once per frame
	void Update () {


	}


	void OnTriggerEnter (Collider other) {
		// (Input.GetKeyDown (KeyCode.Z)) {
		//	isPortal = !isPortal;
		//}

		//if (!Paused.isPause) {
			isPortal = true;
		//}


	}


	void OnGUI() {
		if (isPortal) {
			GUI.Box (new Rect (xloc, yloc, width, height), "Go to the next level?");
				
			if (GUI.Button (new Rect (xloc + xloc/4, yloc+(yloc/4), width/2,height/5), "Yes")) {
					Application.LoadLevel (NextLevel);
				}
				
			if (GUI.Button (new Rect (xloc + xloc/4, yloc + 2*yloc/4, width/2,height/5), "No")) {
				Time.timeScale = scale;
				isPortal = false;
				}


	
		}


	}
}
