using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSprite : MonoBehaviour
{
	public Sprite[] arraySprites;
	SpriteRenderer sprRen;
	float timer;

	void Start ()
	{
		timer = 0;
		sprRen = GetComponent<SpriteRenderer> ();
		sprRen.sprite = arraySprites [Random.Range (0, arraySprites.Length)];
	}

	
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer > 2) {
			timer = 0;
			sprRen.sprite = arraySprites [Random.Range (0, arraySprites.Length)];
		}
	}

	void OnMouseDown ()
	{
		if (sprRen.sprite.name == "star") {
			InitGame.score += 3;
		} else {
			InitGame.score--;
		}
		Destroy (gameObject);
	}

}
