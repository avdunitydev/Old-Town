using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM : MonoBehaviour
{
	public float speed;
	Rigidbody2D enemy;
	Vector2 enemyDirection;
	int[] DIRECT = { -1, 0, 1 };
	public EnemyTriger[] enemyTrigers;
	int i = 0;

	// Use this for initialization
	void Start ()
	{
		//enemyTrig = new EnemyTriger();
		enemy = GetComponent<Rigidbody2D> ();
		enemyDirection = new Vector2 (1, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void FixedUpdate ()
	{
		if (enemyTrigers [i].isTriggerEntry && i < enemyTrigers.Length - 1) {
			direction ();
			i++;
		} else if (i == enemyTrigers.Length - 1) {
			i = 0;
		}
		enemy.AddForce (enemyDirection * 1);
	}

	void direction ()
	{
		enemyDirection = new Vector2 (DIRECT [(int)Random.Range (0, 3)], DIRECT [(int)Random.Range (0, 3)]);
	}

}
