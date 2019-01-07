using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	public Text buttonText;
	public Button myButton;

	// Use this for initialization
	void Start () {
		myButton.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void TaskOnClick () {
			if (transform.position.z == 45 && transform.position.x == 55) {
			buttonText.text = "geklikt 2.0";
		}
		buttonText.text = "geklikt";
	}
}
