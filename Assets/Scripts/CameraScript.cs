﻿using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(target.transform.position);
		transform.position.Set (target.transform.position.x, target.transform.position.y, target.transform.position.z);
	}
}
