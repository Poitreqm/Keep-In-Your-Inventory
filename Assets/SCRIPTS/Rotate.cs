﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (!PauseClick.gameIsPaused)
		{

			transform.Rotate(new Vector3(0, 0, -5));
		}
		else
		{
			this.gameObject.transform.Rotate(new Vector3(0, 0, 0));
		}

	}
}
