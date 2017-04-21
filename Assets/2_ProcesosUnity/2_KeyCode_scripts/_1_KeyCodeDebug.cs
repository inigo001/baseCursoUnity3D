using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1_KeyCodeDebug : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("PULSO S");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("MANTENGO PULSADO A");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("LEVANTO D");
        }


	}
}
