using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kleur : MonoBehaviour {
	
		Material myMaterial;

	// Use this for initialization
	void Start () {
		myMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		if(GeldScript.clicked == true) {
		 myMaterial.color = Color.red;	
		}
	}
}
