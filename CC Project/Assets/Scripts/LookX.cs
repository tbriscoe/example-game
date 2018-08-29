using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour {

	[SerializeField] private float _sensitivity = 1.0f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float _mouseX = Input.GetAxis("Mouse X");

		// Get my current rotation and assign it a new rotation

		// transform.rotation uses Quaternions which is a handful of methods to help us with rotations
		
		// To change the individual angle

		Vector3 newRotation = transform.localEulerAngles;
		newRotation.y += _mouseX * _sensitivity;
		transform.localEulerAngles = newRotation;
		// transform.localEulerAngles = new Vector3(newRotation.x, newRotation.y, newRotation.z);
	}
}
