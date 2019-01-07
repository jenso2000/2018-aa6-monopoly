using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeldScript : MonoBehaviour {
	public Text geldText;
	public int geldAantal;

	
	void Start () {
		//Geld variabele aanmaken
		geldAantal = 1500;
	}
	
	
	void Update () {
		//Geld aanmaken
		geldText.text = "Geld " + geldAantal;
		//Geld afschrijven als je op pijl naar beneden drukt
		if (transform.position.z == 45 && transform.position.x == 55) {
			if (Input.GetKeyDown(KeyCode.DownArrow)) {
				geldAantal = geldAantal - SoundCloud.kostenSoundCloud;
			}
		}
	}
}
