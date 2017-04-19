using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3_ArgumentPassing : MonoBehaviour {

	public int numeroSuperior = 5;

	// Use this for initialization
	void Start () 
	{
		int numeroMulti = 3;

		this.multiplicaPorAlgo ( numeroMulti );
	}

	private void multiplicaPorAlgo( int numeroMulti_ )
	{
		Debug.Log ( numeroMulti_ * this.numeroSuperior);
	}
}
