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
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("down")) {
			int steps = Random.Range(2,12);
			transform.Translate (steps*2,0,0);
			diceText.text = "Je hebt gegooid: " + steps.ToString ();
		}
	}
}
