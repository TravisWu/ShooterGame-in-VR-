using UnityEngine;
using System.Collections;

public class Flying : MonoBehaviour {

	public GameObject oculusLeftEye;
	Rigidbody rr;
	
	public float forwardSpeed = 100f;
	float rotationSpeed = 300f;
	
	Vector3 axis;
	float rotationY;
	float rotationX;
	float rotationZ;
	
	bool start = false;
	
	
	
	// Use this for initialization
	void Start () {
		rr = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space)) {
//			forwardSpeed= 20f;
			start = true;
		} 

		
		
		if(start == true)
		{
			
			FlightMode();
//			if (Input.GetKey (KeyCode.DownArrow)){
//				forwardSpeed = 0f;
//
//
//			}
		}
		
	}
	
	
	
	void FlightMode(){
		
		//get rotation values for the leftEye
		rotationX = oculusLeftEye.transform.localRotation.x / 2;
		rotationY = oculusLeftEye.transform.localRotation.y / 2;
		rotationZ = oculusLeftEye.transform.localRotation.z;
		
		//put them into a vector
		axis = new Vector3 (rotationX, rotationY, rotationZ);
		
		//Rotate
		transform.Rotate (axis * Time.deltaTime * rotationSpeed);
		
		
		rr.velocity = oculusLeftEye.transform.forward * forwardSpeed;
		
		
	}﻿
}
