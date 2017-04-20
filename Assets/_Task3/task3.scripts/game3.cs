using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
	public Transform element;
	public Element[,] elements;
	int sizeX;
	int sizeY;

	// Use this for initialization
	void Start ()
	{
		sizeX = 20;
		sizeY = 50;
		elements = new Element[sizeX, sizeY];

		for (int i = 1; i < sizeX - 1; ++i) {
			for (int j = 1; j < sizeY - 1; ++j) {
				Transform newElement = Instantiate (element, new Vector3 (j, i, 0), 
					                       Quaternion.identity, transform);
				Element getItem = newElement.GetComponent<Element> ();
				getItem.posX = j;
				getItem.posY = i;
				elements [j, i] = getItem;
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
