using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopMenuTest : MonoBehaviour {

	public GameObject MenuTest;



	// Use this for initialization
	void Awake () {
		GameObject MenuTest = GameObject.Find ("MenuCardTest");
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.M)) {
			PopMenu ();
		}
	}

	public void PopMenu(){
		MenuTest.SetActive (true);

	}
}

