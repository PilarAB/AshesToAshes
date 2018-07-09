using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
    public GameObject CanvasCode;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            CanvasCode.SetActive(true);
        }
    }
}
