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
		 Vector3 position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			print("test1");
			int steps = Random.Range(2,12);
			diceText.text = "Je hebt " + steps.ToString () + " gegooid";
			for (int i = steps; i > 0; i-- ) {
				print(transform.position.z);
			if (transform.position.z > -45) {
				
			transform.Translate (0,0,-10);
			} else if (transform.position.z <= -45) {
				print("test2");
				transform.Translate(-10,0,0);
			}
			}
	//	} else if (Input.GetKeyDown("space") && transform.position.z < -45) {
		//	transform.Translate (steps*-10,0,0);
		}
	}
}