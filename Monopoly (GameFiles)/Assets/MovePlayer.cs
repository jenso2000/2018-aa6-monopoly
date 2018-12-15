using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {
	public int steps;
	private int dice;
	public Text diceText;
	private transform.position.z = GetAxis("Z");
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && transform.position.z > -45 ) {
			int steps = Random.Range(2,12);
			transform.Translate (0,0,steps*-10);
			diceText.text = "Je hebt gegooid: " + steps.ToString ();
		} else if (Input.GetKeyDown("space") && transform.position.z < -45) {
			transform.Translate (steps*-10,0,0);
		}
	}
}
