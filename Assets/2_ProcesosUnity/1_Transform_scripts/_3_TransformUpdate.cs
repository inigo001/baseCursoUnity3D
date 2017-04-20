using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3_TransformUpdate : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
    {
        this.transform.Translate(new Vector3(-0.5f, 0, 0), Space.World);

        this.transform.Rotate(new Vector3(0, 0, 30));
	}
}
