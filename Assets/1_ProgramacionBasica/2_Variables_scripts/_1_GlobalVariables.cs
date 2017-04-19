using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*----------------------------------*/

public class _1_GlobalVariables : MonoBehaviour {


	int numeroEntero = 2;

	float numeroConComa = 2.789456f;

	string textoConLetras = "Soy un texto con letras";

	bool verdaderoOFalso = false;

	/* - */

	void Start () 
	{
		Debug.Log (this.numeroEntero);

		Debug.Log (this.numeroConComa);

		Debug.Log (this.textoConLetras);

		Debug.Log (this.verdaderoOFalso);
	}

}
