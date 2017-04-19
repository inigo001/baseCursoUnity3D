using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3_VariablesOperations : MonoBehaviour {

	public int numeroPrimero = 27;

	public int numeroSegundo = 3;

	public string restaTexto = "RESTA: ";

	/* - */

	void Start () 
	{
		Debug.Log( "SUMA: " + (this.numeroPrimero + this.numeroSegundo ));
		Debug.Log( this.restaTexto + (this.numeroPrimero - this.numeroSegundo ));
		Debug.Log( "MULTIPLICACION: " + (this.numeroPrimero * this.numeroSegundo ));
		Debug.Log( "DIVISION: " + (this.numeroPrimero / this.numeroSegundo ));
	}
	

}
