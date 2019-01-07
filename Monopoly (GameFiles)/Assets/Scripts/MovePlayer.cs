using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {
	// Variabelen aanmaken
	public int steps;
	private int dice;
	public Text diceText;
	
	
	void Start () {
		//Vector aanmaken om player te verplaatsen
		 transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
	}
	
	
	void Update () {
		//Als spatie ingedrukt verplaats random getal tussen 2 en 12
		if (Input.GetKeyDown("space")) {
			int steps = Random.Range(2,12);
			//int steps = 1;
			diceText.text = "Je hebt " + steps.ToString () + " gegooid";
			for (int i = steps; i > 0; i-- ) {
				//Als de player bij een einde van het bord uitkomt veranderd de bewegingsrichting
			if (transform.position.z > -45 && transform.position.x == 55) {
				transform.Translate (0,0,-10);
			} else if (transform.position.z == -45 && transform.position.x > -45) {
				transform.Translate(-10,0,0);
			} else if (transform.position.z < 55 && transform.position.x == -45) {
				transform.Translate(0,0,10);
			} else if (transform.position.z == 55 && transform.position.x < 55){
				transform.Translate(10,0,0);
			}
		}
	}
	}
}