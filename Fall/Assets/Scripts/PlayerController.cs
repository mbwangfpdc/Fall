using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	public Rigidbody2D body;

	void Punch() {

	}

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		float Horizontal = 0;
		Horizontal -= (Input.GetKey(KeyCode.A) ? 1 : 0);
		Horizontal += (Input.GetKey(KeyCode.D) ? 1 : 0);
		float Vertical = 0;
		Vertical -= (Input.GetKey(KeyCode.S) ? 1 : 0);
		Vertical += (Input.GetKey(KeyCode.W) ? 1 : 0);

		// TODO: eventually find out wtf is wrong with pressing multiple directions
		body.velocity = new Vector2(Horizontal * speed, Vertical * speed);

		if(Input.GetButtonDown("Fire1")) {
			Debug.Log(Input.mousePosition);
		}
	}


}
