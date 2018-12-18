using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeldScript : MonoBehaviour {
	public Text geldText;
	public int geldAantal;

	// Use this for initialization
	void Start () {
		geldAantal = 1500;
	}
	
	// Update is called once per frame
	void Update () {
		geldText.text = "Geld " + geldAantal;
	}
}
