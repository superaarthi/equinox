using UnityEngine;
using System.Collections;


public class Dialog : MonoBehaviour {

	public Texture2D image;
	public string text;
//	public int maxDialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.Z)) {
				CharDialog charDia = other.gameObject.GetComponent<CharDialog> ();
				if (charDia.enableSpeech) {
					charDia.enableSpeech = false;
				} else {
					charDia.text = text;
					charDia.image = image;
					charDia.enableSpeech = true;
				}
			}
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<CharDialog> ().enableSpeech = false;
		}
	}

}
