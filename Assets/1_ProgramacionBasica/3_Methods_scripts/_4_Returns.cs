using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4_Returns : MonoBehaviour {

	public int numeroSuperior = 5;

	// Use this for initialization
	void Start () 
	{
		int numeroMulti = 7;

		Debug.Log ( this.multiplicaPorAlgo ( numeroMulti ) );
	}

	private int multiplicaPorAlgo( int numeroMulti_ )
	{
		return (numeroMulti_ * this.numeroSuperior);
	}
}
