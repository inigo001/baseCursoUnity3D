using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4_IfBooleans : MonoBehaviour {

    public bool pepeEsAlto = true;

	// Use this for initialization
	void Start () 
    {
		
        if (this.pepeEsAlto == true)
        {
            Debug.Log("Pepe es Alto");
        }

        if (this.pepeEsAlto != true)
        {
            Debug.Log("Pepe NO es Alto");
        }

	}

}
