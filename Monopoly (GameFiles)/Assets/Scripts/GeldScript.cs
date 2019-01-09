using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeldScript : MonoBehaviour {
    // Maak de benodigde variabelen aan
    public Text geldText;
    public int geldAantal;
    public Text buttonText;
    public Button myButton;
    public GameObject buttonContinue;
    public static bool clicked;
    public Text eigenaarText;
	public Text BankText;
	public int BankSaldo;

    void Start() {
        geldAantal = 1500; //Geld variabele aanmaken
        myButton.onClick.AddListener(TaskOnClick); //"luistert" naar of er geklikt wordt op de button
        buttonContinue.SetActive(false); // De button moet nog niet verschijnen
        clicked = false; // Er is nog niet op de button geklikt
    }


    void Update() {
        geldText.text = "Geld " + geldAantal; //Geld aanmaken
		BankText.text = "Bank: " + BankSaldo;
        if (transform.position.z == 45 && transform.position.x == 55) // Laat de button zien als hij op het eerste vakje staat
        {
            buttonContinue.SetActive(true);
            if (clicked == true)
            {
                SoundCloud.eigenaarb207 = "Speler1";
                eigenaarText.text = "Eigenaar: " + SoundCloud.eigenaarb207;
            }
        } else // Anders niet laten zien (of weer laten verdwijnen)
        {
            buttonContinue.SetActive(false);
            eigenaarText.text = "nog geen eigenaar";
        } if (transform.position.z == -45 && transform.position.x == -45){
			geldAantal = geldAantal + BankSaldo;
			BankSaldo = 0;
		}
		
    }

    void TaskOnClick()
    {
        if (clicked == false) //Als er nog niet eerder op de button geklikt is voer dit dan uit
        {
            buttonText.text = "gekocht!"; // Laat zien dat de button gekocht is
            geldAantal = geldAantal - SoundCloud.kostenSoundCloud; // Verander het geld aantal
            clicked = true; // Sla op dat er geklikt is
			BankSaldo = BankSaldo + SoundCloud.kostenSoundCloud;
        } else if (clicked == true) { // Doe dit als er al geklikt is
            buttonText.text = "niet zo hebberig"; // Geef aan dat nog een keer klikken geen zin heeft
        }
    }
}
