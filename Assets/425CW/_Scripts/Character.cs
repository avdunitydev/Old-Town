using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	public float speed;
	float step;
	public Rigidbody2D fire;
	Rigidbody2D mZombie;
	Vector2 fireDirection;
	SpriteRenderer sprr;

	// Use this for initialization
	void Start ()
	{
		sprr = GetComponent<SpriteRenderer> ();
		mZombie = GetComponent<Rigidbody2D> ();
		fireDirection = new Vector2 (-1, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		step = speed * Time.deltaTime;
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.W)) {
			mZombie.velocity = new Vector2 (mZombie.velocity.x, step);
		} else if (Input.GetKey (KeyCode.S)) {
			mZombie.velocity = new Vector2 (mZombie.velocity.x, -step);
		}

		if (Input.GetKey (KeyCode.A)) {
			sprr.flipX = false;
			mZombie.velocity = new Vector2 (-step, mZombie.velocity.y);
		} else if (Input.GetKey (KeyCode.D)) {
			sprr.flipX = true;
			mZombie.velocity = new Vector2 (step, mZombie.velocity.y);
		}
	}
}
