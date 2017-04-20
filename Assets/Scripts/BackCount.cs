using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCount : MonoBehaviour
{
	[SerializeField]
	Sprite[] backCount;
	SpriteRenderer sprRenderer;
	float timer;
	int count;


	// Use this for initialization
	void Start ()
	{
		timer = 0f;
		sprRenderer = GetComponent<SpriteRenderer> ();
		//sprRenderer.sprite = backCount [backCount.Length - 1];
		count = backCount.Length;
	}
	
	// Update is called once per frame


	void Update ()
	{
		timer += Time.deltaTime;
		if (timer > 0.5 && count > 0) {
			timer = 0f;
			sprRenderer.sprite = backCount [count - 1];
			--count;
		}
		if (count == 0) {
			Destroy (gameObject);
		}


	}


}
