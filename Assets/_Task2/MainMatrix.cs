using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMatrix : MonoBehaviour
{
	int sizeX;
	int sizeY;
	public Item[,] matrix;
	public GameObject item;


	// Use this for initialization
	void Start ()
	{
		sizeX = 13;
		sizeY = 10;
		matrix = new Item[sizeX, sizeY];

		for (int i = 1; i < sizeY - 1; ++i) {
			for (int j = 1; j < sizeX - 1; ++j) {
				GameObject itemGO = Instantiate (item, new Vector3 (j - 6, i - 4, 0), 
					                    Quaternion.identity, transform);
				Item getItem = itemGO.GetComponent<Item> ();
				getItem.posX = j;
				getItem.posY = i;
				matrix [j, i] = getItem;
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
