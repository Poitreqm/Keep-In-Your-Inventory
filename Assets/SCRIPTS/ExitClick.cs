﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitClick : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnMouseDown()
    {
		Debug.Log("QUIT");
       Application.Quit();
    }
}
