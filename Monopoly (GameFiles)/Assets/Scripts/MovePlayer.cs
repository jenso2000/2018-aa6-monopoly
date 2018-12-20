using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {
	public int steps;
	private int dice;
	public Text diceText;
	// Use this for initialization
	void Start () {
		 transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
            int steps = Random.Range(2,12);
            //int steps = 1;
			diceText.text = "Je hebt " + steps.ToString () + " gegooid";
			for (int i = steps; i > 0; i-- ) {
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