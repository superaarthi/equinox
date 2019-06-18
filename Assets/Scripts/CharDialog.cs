using UnityEngine;
using System.Collections;

public class CharDialog : MonoBehaviour {

	public Texture2D image;
	public string text;
	public bool enableSpeech=false;
	public bool start = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			if (start) {
				enableSpeech = false;
				start = false;
			}
		}
	}

	void OnGUI () {
		if(enableSpeech){
			GUI.backgroundColor = Color.green;
			GUI.Box(new Rect(140,Screen.height-130,Screen.width-300,120),"");
			GUI.DrawTexture(new Rect(150,Screen.height-120,60,60),image, ScaleMode.StretchToFill, true, 10.0f);
			GUI.Label(new Rect(220,Screen.height-120,Screen.width-400,110),text);
		}
	}
/*
	public void StartDialogue () {
		if(comboPointer>=maxDialogue){
			enableSpeech=false;
			images=null;
			subtitles=null;
			comboPointer=0;
//			maxDialogue=0;
		}
		else{
			Debug.Log("we got to here");
//			comboPointer++;
//			RestartDialogue();
		}
	}

	void RestartDialogue (){
		StartDialogue();
	} */
}
