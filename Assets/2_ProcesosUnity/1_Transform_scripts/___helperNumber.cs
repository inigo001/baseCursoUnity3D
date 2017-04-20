using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ___helperNumber : MonoBehaviour {

    public Transform cuadro4;
    private float timer = 0;
	
	// Update is called once per frame
	void Update () 
    {
        float xPos = this.cuadro4.position.x;

        this.timer = this.timer + Time.deltaTime;

        int singleTime = (int)this.timer;

        this.GetComponent<Text>().text = "xpos: " + xPos + "\ntime: " + singleTime;
	}
}
