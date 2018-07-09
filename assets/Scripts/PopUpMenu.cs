using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour {

	public GameObject panMenu;


	public void PopMenu(){
		panMenu.SetActive (true);

	}

	// Use this for initialization
	void Start () {
		panMenu.SetActive (false);
	}
	void Update(){
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			PopMenu ();
			}
		}
	}
	


