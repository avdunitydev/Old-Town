using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
	public int posX;
	public int posY;
	public Sprite[] itemSprites;
	SpriteRenderer sprr;

	// Use this for initialization
	void Start ()
	{
		sprr = GetComponent<SpriteRenderer> ();
		sprr.sprite = itemSprites [Random.Range (0, itemSprites.Length)];
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
