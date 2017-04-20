using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2_TransformMove : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        this.transform.Translate(new Vector3(-1, -1, -1));

        this.transform.Rotate(new Vector3(0, 0, 20));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
