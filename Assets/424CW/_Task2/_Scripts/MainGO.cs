using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGO : MonoBehaviour
{
	public Transform cube;
	public Transform ball;
	public float speed;


	int rnd ()
	{
		return Random.Range (-14, 14);
	}

	// Use this for initialization
	void Start ()
	{
		Instantiate (ball, new Vector3 (rnd (), rnd (), 0), Quaternion.identity, transform);
		Instantiate (cube, new Vector3 (rnd (), rnd (), 0), Quaternion.identity, transform);

	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}
}
