using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public int posX;
	public int posY;
	public Sprite[] itemSprites;
	SpriteRenderer sprr;
	MainMatrix mainMatrix;


	// Use this for initialization
	void Start ()
	{
		sprr = GetComponent<SpriteRenderer> ();
		mainMatrix = GetComponentInParent<MainMatrix> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnMouseEnter ()
	{
		sprr.sprite = itemSprites [1];
		sprr.transform.localScale.Scale (new Vector3 (0.1f, 0.1f, 0f));
		for (int i = posX - 1; i < posX + 2; ++i) {
			for (int j = posY - 1; j < posY + 2; ++j) {
				if (mainMatrix.matrix [i, j]) {
					if (i == posX && j == posY)
						continue;
					mainMatrix.matrix [i, j].changeAroundSprite ();                    
				}
			}
		}
	}

	void OnMouseExit ()
	{
		sprr.sprite = itemSprites [0];
		for (int i = posX - 1; i < posX + 2; ++i) {
			for (int j = posY - 1; j < posY + 2; ++j) {
				if (mainMatrix.matrix [i, j]) {
					if (i == posX && j == posY)
						continue;
					mainMatrix.matrix [i, j].clearSprite ();                    
				}
			}
		}
	}

	public void changeAroundSprite ()
	{
		sprr.sprite = itemSprites [2];
	}

	public void clearSprite ()
	{
		sprr.sprite = itemSprites [0];
	}

}
