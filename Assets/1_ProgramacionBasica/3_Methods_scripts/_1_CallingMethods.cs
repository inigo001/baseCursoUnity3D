using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1_CallingMethods : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		this.soyUnMetodo ();
	}

	private void soyUnMetodo()
	{
		Debug.Log ("¿ME HAS LLAMADO?");
	}
}
