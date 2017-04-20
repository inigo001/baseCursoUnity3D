using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _5_ConditionExtras : MonoBehaviour {

    public bool esPepeAlto = false;

    public int numeroA = 5;

    public int numeroB = 7;

	// Use this for initialization
	void Start () {
		

        if ((this.numeroA >= this.numeroB) && (this.esPepeAlto == true))
        {
            Debug.Log("numeroA es mayor o igual que numeroB   Y  Pepe es Alto");
        }
        else if ((this.numeroA < this.numeroB) || (this.esPepeAlto == false))
        {
            Debug.Log("numeroA es menor que numeroB    O   Pepe NO es Alto");
        }
        else
        {
            Debug.Log("El resto de opciones");
        }


        /*
         *  == IGUAL
         *  != DISTINTO
         *  >= MAYOR O IGUAL
         *  <= MENOR O IGUAL
         *  < MENOR
         *  > MAYOR
         * 
         *  && AND (Y)
         *  || OR (O)
         * 
         */

	}
	

}
