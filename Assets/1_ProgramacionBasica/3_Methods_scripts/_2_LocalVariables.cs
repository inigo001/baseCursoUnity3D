using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2_LocalVariables : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		this.metodoLocal ();
	}
	
	private void metodoLocal()
	{
		int soyUnNumeroLocal = 1;

		Debug.Log (soyUnNumeroLocal);
	}
}
