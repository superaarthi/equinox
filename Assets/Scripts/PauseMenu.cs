using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {


	public bool isPause = false;
	public string PortLocation;


	int width = Screen.width/3;
	int height = Screen.height/4;
	int xloc; 
	int yloc; 
	private Portal Port;


	float scale;
	// Use this for initialization
	void Start () {
		scale = Time.timeScale;

		xloc = Screen.width/2 - width/2;
		yloc = Screen.height/2 - 2*height/3;


		//Port = GameObject.Find (PortLocation).GetComponent<Portal>();
	}
	
	// Update is called once per frame
	void Update () {
	
		//if (Input.GetKeyDown (KeyCode.Escape) && !Port.isPortal) {
        if (Input.GetKeyDown (KeyCode.Escape)){
            isPause = !isPause;
		}
		if (isPause){
			Time.timeScale = 0.0f;
		}
			
		else {
			Time.timeScale = scale;
		}

	}


	void OnGUI() {

		if (isPause) {
			GUI.Box (new Rect (xloc, yloc, width, height), "Pause: Press Esc to Resume");
			
			if (GUI.Button (new Rect (xloc + xloc/4, yloc+(yloc/4), width/2,height/5), "Resume")) {
				isPause = !isPause;
			}

			if (GUI.Button (new Rect (xloc + xloc/4, yloc + 2*yloc/4, width/2,height/5), "Main Menu")) {
				Application.LoadLevel ("Menu");
			}
		}




	}
}
