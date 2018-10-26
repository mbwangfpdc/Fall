using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	public Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		float Horizontal = 0;
		Horizontal -= (Input.GetKey(KeyCode.LeftArrow) ? 1 : 0);
		Horizontal += (Input.GetKey(KeyCode.RightArrow) ? 1 : 0);
		float Vertical = 0;
		Vertical -= (Input.GetKey(KeyCode.DownArrow) ? 1 : 0);
		Vertical += (Input.GetKey(KeyCode.UpArrow) ? 1 : 0);

		// TODO: eventually find out wtf is wrong with pressing multiple directions
		body.velocity = new Vector2(Horizontal * speed, Vertical * speed);
	}
}
