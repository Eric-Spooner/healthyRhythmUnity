﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour {

	private Image controlKross;

	// Use this for initialization
	void Start () {
		controlKross = GameObject.Find ("controlKross").GetComponent<Image> ();
	}

	// Update is called once per frame
	//void Update () {
	public void androidReceiveSignal(string value) {
        int intVal = int.Parse(value);
        controlKross.fillAmount = intVal;
	}

}
