﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForward : MonoBehaviour {

    // speed const
    public float speedMultiplier; 

    /* blah */ 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Translate(Vector3.forward * speedMultiplier * Time.deltaTime, Space.World); 
	}
}
