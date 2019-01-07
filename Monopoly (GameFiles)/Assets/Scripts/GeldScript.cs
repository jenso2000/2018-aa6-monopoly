using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeldScript : MonoBehaviour {
    public Text geldText;
    public int geldAantal;
    public Text buttonText;
    public Button myButton;
    public GameObject buttonContinue;
    public bool clicked;


    void Start() {
        //Geld variabele aanmaken
        geldAantal = 1500;
        myButton.onClick.AddListener(TaskOnClick);
        buttonContinue.SetActive(false);
        clicked = false;
    }


    void Update() {
        //Geld aanmaken
        geldText.text = "Geld " + geldAantal;
        if (transform.position.z == 45 && transform.position.x == 55)
        {
            buttonContinue.SetActive(true);
        } else
        {
            buttonContinue.SetActive(false);
        }
        //Geld afschrijven als je op pijl naar beneden drukt
    }

    void TaskOnClick()
    {
        if (transform.position.z == 45 && transform.position.x == 55 && clicked == false)
        {
            buttonText.text = "gekocht!";
            geldAantal = geldAantal - SoundCloud.kostenSoundCloud;
            clicked = true;
        } else if (transform.position.z == 45 && transform.position.x == 55 && clicked == true) {
            buttonText.text = "niet zo hebberig";
        } 
    }
}
