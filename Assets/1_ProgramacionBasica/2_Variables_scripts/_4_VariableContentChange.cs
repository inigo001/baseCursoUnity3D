using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4_VariableContentChange : MonoBehaviour {

	public int numeroA = 27;

	public int numeroB = 5;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("NUMERO 1: " + this.numeroA);

		this.numeroA = 18;

		Debug.Log ("NUMERO 2: " + this.numeroA);

		this.numeroA = this.numeroA + this.numeroB;

		Debug.Log ("NUMERO 3: " + this.numeroA);
	}

}
