﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {


    public float speed = 6.0f;
    public float gravity = -9.8f;

    private CharacterController _charCont;

	// Use this for initialization
	void Start () {
        _charCont = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3 (deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime; //Ensure the gamelogic runs at the same speed regardless of framerate
        movement = transform.TransformDirection(movement);
        _charCont.Move(movement);
	}
}
