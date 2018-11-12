using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour {

	private Image controlKross;
	double halfScreenHorizontal = Screen.width / 2.0;
	double halfScreenVertical = Screen.height / 2.0;

	// Use this for initialization
	void Start () {
		controlKross = GameObject.Find ("controlKross").GetComponent<Image> ();
	}

	// Update is called once per frame
	//void Update () {
	public void androidReceiveSignal(string value) {
        int intVal = int.Parse(value);
        if (intVal > 0)
        {
           controlKross.fillAmount = 100;
        }
        else
        {
            controlKross.fillAmount = 0;
        }
	}

}
