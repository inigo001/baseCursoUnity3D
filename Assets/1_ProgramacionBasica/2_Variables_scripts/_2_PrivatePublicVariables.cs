using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2_PrivatePublicVariables : MonoBehaviour {

	private int numeroEntero = 2;

	public float numeroConComa = 2.789456f;

	public string textoConLetras = "Soy un texto con letras";

	private bool verdaderoOFalso = false;

	/* - */

	void Start () 
	{
		Debug.Log (this.numeroEntero);

		Debug.Log (this.numeroConComa);

		Debug.Log (this.textoConLetras);

		Debug.Log (this.verdaderoOFalso);
	}
}
