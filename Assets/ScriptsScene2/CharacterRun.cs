using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRun : MonoBehaviour
{

	[SerializeField]
	Sprite[] characterRun;
	SpriteRenderer sprRend;
	float timer = 30f;
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
				for (int i = 0; i < characterRun.Length; ++i) {
					if (i == characterRun.Length) {
						i = 0;
					}
					sprRend.sprite = characterRun [i];
				}

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
