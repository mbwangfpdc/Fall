using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour {

	public static List<GameObject> trees = new List<GameObject>();

	public int health;

	void Kill() {
		// spin up animation

		// remove self from trees
	}

	// Use this for initialization
	void Start () {
		trees.Add(gameObject);
		health = 100;
	}

	// Update is called once per frame
	void Update () {
		if(health < 0) Kill();
	}

	public void take_damage(int damage_taken){
		health -= damage_taken;
	}
}
