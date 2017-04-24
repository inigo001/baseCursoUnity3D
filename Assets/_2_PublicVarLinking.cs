using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2_PublicVarLinking : MonoBehaviour {

    public GameObject limiteSuperior;
    public GameObject limiteInferior;

	// Use this for initialization
	void Start () 
    {
        Debug.Log(limiteInferior.name);
        Debug.Log(limiteSuperior.name);
	}
        
}
