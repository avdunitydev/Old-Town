using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
	[SerializeField]
	Sprite[] characters;
	SpriteRenderer sprRend;
	float timer = 5f;
	bool isRun;

	// Use this for initialization
	void Start ()
	{
		isRun = true;
		sprRend = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isRun) {
			if (timer > 0) {
				timer -= Time.deltaTime;
				sprRend.sprite = characters [(int)Random.Range (0, characters.LongLength)];
			} else if (timer <= 0) {
				isRun = false;
			}
		}
	}

	void OnMouseDown ()
	{
		isRun = false;
		Destroy (gameObject);
	}

	void OnMouseEnter ()
	{
		isRun = false;
		sprRend.color = new Color (1, 1, 1, 0.2f);
	}

	void OnMouseExit ()
	{
		isRun = true;
		sprRend.color = new Color (1, 1, 1, 1f);

	}
}