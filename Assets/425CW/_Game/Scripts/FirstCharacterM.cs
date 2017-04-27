using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCharacterM : MonoBehaviour
{
	public float speed;
	public Rigidbody2D fire;

	Rigidbody2D character;
	Vector2 bulletDirection;



	// Use this for initialization
	void Start ()
	{
		bulletDirection = new Vector2 (1, 0);
		character = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			Rigidbody2D bull = Instantiate (fire, transform.position, Quaternion.identity);
			bull.AddForce (bulletDirection * 600);
		}

	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.W)) {
			character.velocity = new Vector2 (character.velocity.x, speed * Time.deltaTime);
			bulletDirection = new Vector2 (0, 1);
		} else if (Input.GetKey (KeyCode.S)) {
			character.velocity = new Vector2 (character.velocity.x, -speed * Time.deltaTime);
			bulletDirection = new Vector2 (0, -1);
		}

		if (Input.GetKey (KeyCode.A)) {
			character.velocity = new Vector2 (-speed * Time.deltaTime, character.velocity.y);
			bulletDirection = new Vector2 (-1, 0);
		} else if (Input.GetKey (KeyCode.D)) {
			character.velocity = new Vector2 (speed * Time.deltaTime, character.velocity.y);
			bulletDirection = new Vector2 (1, 0);
		}
	}
}
