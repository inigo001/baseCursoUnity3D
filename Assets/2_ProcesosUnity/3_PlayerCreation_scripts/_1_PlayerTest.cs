using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1_PlayerTest : MonoBehaviour {

    // Recordar introducir el tag PLAYER

    public int verticalSpeed = 3;
    public int horizontalSpeed = 2;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(-Vector3.up * verticalSpeed * Time.deltaTime);
        }
            
        this.transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);

	}
}
