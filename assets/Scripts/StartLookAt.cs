using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLookAt : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        transform.LookAt(Camera.main.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }

  

}
