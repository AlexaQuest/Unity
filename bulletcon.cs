﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcon : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(5.0f, 0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
