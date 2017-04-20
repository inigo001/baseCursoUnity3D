using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1_TransformVector2 : MonoBehaviour {

    public Vector3 nuevaPosicion = new Vector3(7,3);

    public Vector3 nuevaRotacion = new Vector3(0,0,45); 

    public Vector3 nuevaEscala = new Vector3(4, 4, 4);


	// Use this for initialization
	void Start () 
    {
        this.transform.position = this.nuevaPosicion;

        this.transform.eulerAngles = this.nuevaRotacion;

        this.transform.localScale = this.nuevaEscala;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
