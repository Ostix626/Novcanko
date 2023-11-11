using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveAmount : MonoBehaviour {
    static System.Random r = new System.Random();
    public static int amountNumber, givenNumber;
    public Text givenTxt, amountTxt; 

    void Start() {
    	amountNumber = r.Next(1, 100);
    	amountTxt.text = "" + amountNumber + " EUR";
    	//Debug.Log(amount_number);
    	givenNumber = 0;
    }

    public void Update() {
    	givenTxt.text = "" + givenNumber + " EUR";
        //Debug.Log("givenTxt = " + givenNumber);
        if (NextLvl.proceed) {
            givenNumber = 0;
            givenTxt.text = "" + givenNumber + " EUR";
            amountNumber = r.Next(1, 100);
            amountTxt.text = "" + amountNumber + " EUR";
            NextLvl.proceed = false;
        }
    }
}
