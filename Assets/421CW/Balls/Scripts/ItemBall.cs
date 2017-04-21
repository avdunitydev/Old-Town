using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBall : MonoBehaviour
{
	RunScene run;

	// Use this for initialization
	void Start ()
	{
		run = GetComponentInParent<RunScene> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnMouseDown ()
	{
		ItemBall[] all = run.GetComponentsInChildren<ItemBall> ();
		foreach (ItemBall a in all) {
			if (a.gameObject.name.Equals (gameObject.name)) {
				Destroy (a.gameObject);
			}
		}
	}

	void OnMouseEnter ()
	{

	}
}
