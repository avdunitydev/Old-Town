using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Тест подій
public class TestColl : MonoBehaviour
{

	void OnCollisionEnter2D (Collision2D coll)
	{
		print ("OnCollisionEnter2D " + name + " * " + coll.transform.name);
	}

	void OnCollisionStay2D (Collision2D coll)
	{
		print ("OnCollisionStay2D " + name + " * " + coll.transform.name);
	}

	void OnCollisionExit2D (Collision2D coll)
	{
		print ("OnCollisionExit2D " + name + " * " + coll.transform.name);
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		print ("OnTriggerEnter2D " + name + " * " + coll.name);
	}

	void OnTriggerStay2D (Collider2D coll)
	{
		print ("OnTriggeStay2D " + name + " * " + coll.name);
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		print ("OnTriggerExit2D " + name + " * " + coll.name);
	}
}
