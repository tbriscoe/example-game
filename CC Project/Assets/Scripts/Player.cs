﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private CharacterController _contoller;
	[SerializeField] private float _speed = 3.5f;
	private float _gravity = 9.81f;
	// Use this for initialization
	void Start () 
	{
		_contoller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	 CalculateMovement();
	}

	void CalculateMovement()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
		Vector3 velocity = direction * _speed;
		velocity.y -= _gravity;
		velocity = transform.TransformDirection(velocity); // reassign world space values
		_contoller.Move(velocity * Time.deltaTime); // this moves us in world space
		// our players coordinate system is getting passed in as local space
	}
}
