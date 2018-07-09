using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButtons : MonoBehaviour {

	public GameObject canvasButtons;

	public void HideTheButtons()
	{
		canvasButtons.SetActive (false);
	}
	public void ShowTheButtons()
	{
		canvasButtons.SetActive (true);
	}

}
