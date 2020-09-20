﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

	public float speed;
	public float startX;
	public float endX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () 
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		if (transform.position.x <= endX){
			Vector2 pos = new Vector2(startX, transform.position.y);
			transform.position = pos;
		}
		
	}
}