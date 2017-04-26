using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriger : MonoBehaviour
{
	public bool isTriggerEntry;

	// Use this for initialization
	void Start ()
	{
		isTriggerEntry = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		isTriggerEntry = true;
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		isTriggerEntry = false;
	}
}
