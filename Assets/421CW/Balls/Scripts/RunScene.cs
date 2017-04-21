using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunScene : MonoBehaviour
{
	public Transform redSphere;
	public Transform greenSphere;
	public Transform bluSphere;
	public Transform yellowSphere;

	int rnd ()
	{
		return Random.Range (3, 14);
	}

	void initRSphere ()
	{
		for (int i = 1; i < rnd (); ++i) {
			Instantiate (redSphere, new Vector3 (rnd () - 8, rnd () - 8, 0), Quaternion.identity, transform);
		}
	}

	void initGSphere ()
	{
		for (int i = 1; i < rnd (); ++i) {
			Instantiate (greenSphere, new Vector3 (rnd () - 8, rnd () - 8, 0), Quaternion.identity, transform);
		}
	}

	void initBSphere ()
	{
		for (int i = 1; i < rnd (); ++i) {
			Instantiate (bluSphere, new Vector3 (rnd () - 8, rnd () - 8, 0), Quaternion.identity, transform);
		}
	}

	void initYSphere ()
	{
		for (int i = 1; i < rnd (); ++i) {
			Instantiate (yellowSphere, new Vector3 (rnd () - 8, rnd () - 8, 0), Quaternion.identity, transform);
		}
	}

	// Use this for initialization
	void Start ()
	{
		initRSphere ();
		initGSphere ();
		initBSphere ();
		initYSphere ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}




}
