using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterZ : MonoBehaviour
{
	public float speed;
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
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.W)) {
			mZombie.velocity = new Vector2 (mZombie.velocity.x, (speed * Time.deltaTime));
		} else if (Input.GetKey (KeyCode.S)) {
			mZombie.velocity = new Vector2 (mZombie.velocity.x, -(speed * Time.deltaTime));
		}

		if (Input.GetKey (KeyCode.A)) {
			sprr.flipX = false;
			mZombie.velocity = new Vector2 (-(speed * Time.deltaTime), mZombie.velocity.y);
		} else if (Input.GetKey (KeyCode.D)) {
			sprr.flipX = true;
			mZombie.velocity = new Vector2 ((speed * Time.deltaTime), mZombie.velocity.y);
		}
	}
}
