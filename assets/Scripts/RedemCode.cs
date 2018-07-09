using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedemCode : MonoBehaviour {

	public GameObject CodeCanvas;


	// Use this for initialization
	void Awake () {
		//GameObject CodeCanvas = GameObject.Find ("RedemCodeCanvas");
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.C)) {
			RedemTheCode ();
			print ("C");
		}
	}

	public void RedemTheCode(){
		CodeCanvas.SetActive (true);

	}
}

