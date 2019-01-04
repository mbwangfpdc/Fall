using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	enum EnemyState {
		Looking = 0,
		Moving = 1,
		Chopping = 2
	}

	public float speed;
	public Rigidbody2D rb;
	public BoxCollider2D bc;

	public Vector3 target_pos;
	public BoxCollider2D target_collider;

	EnemyState state;

	void TargetClosestTree() {
		float min_dist = Vector3.Distance(transform.position, TreeController.trees[0].transform.position);
		GameObject closest = TreeController.trees[0];
		for (int x = 1; x < TreeController.trees.Count; ++x) {
			float dist = Vector3.Distance(transform.position, TreeController.trees[x].transform.position);
			if (dist < min_dist) {
				min_dist = dist;
				closest = TreeController.trees[x];
			}
		}

		target_pos = closest.transform.position;
		target_collider = closest.GetComponent<BoxCollider2D>();
	}

	void MoveTowardsTarget() {
		rb.position = Vector3.MoveTowards(rb.position, target_pos, speed * Time.deltaTime);
	}

	// EngageTree() {} <- InvokeRepeating call, with AttackTree

	// AttackTree() damages tree, animation?

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		bc = GetComponent<BoxCollider2D>();
		state = EnemyState.Looking;

		// Randomize type of enemy?
	}


	void Chop(GameObject target_tree) {
		TreeController treeScript = target_tree.GetComponent<TreeController>();
		treeScript.take_damage(5);
		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
		switch(state) {
			case EnemyState.Moving:
				MoveTowardsTarget();
				if (Physics2D.IsTouching(bc, target_collider)) {
					state = EnemyState.Chopping;
				}
				break;
			case EnemyState.Chopping:
				// TODO make em chop
				Chop(target_collider.gameObject);
				break;
			case EnemyState.Looking:
				TargetClosestTree();
				state = EnemyState.Moving;
				break;
		}
		// What state is enemy in?

		// if MOVING at junction, check where the dest. is and randomize next direction

		// if combat with tree and
	}
}
