﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3_IfElseIf : MonoBehaviour {


    #pragma warning disable 0162

	// Use this for initialization
	void Start () 
	{

		if (5 > 7) 
		{
			Debug.Log ("CINCO ES MAYOR QUE SIETE");
		} 
		else if (5 < 7) 
		{
			Debug.Log ("CINCO ES MENOR QUE SIETE");
		} 
		else 
		{
			Debug.Log ("CINCO NO ES NI MAYOR NI MENOR QUE SIETE");
		}
	}

    #pragma warning restore 0162



}
