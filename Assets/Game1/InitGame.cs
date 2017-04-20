using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
	public static int score;
	public Transform objSprite;
	float timer;
	int timeSpawn;
	float timeGame = 20;
	bool isGame;

	void AddSpriteObj ()
	{
		Instantiate (objSprite, new Vector3 (Random.Range (-5, 6), Random.Range (-3, 6), 0), Quaternion.identity, transform);
	}

	void Start ()
	{
		isGame = true;
		score = 0;
		timer = 0;
		timeSpawn = Random.Range (2, 6);
		for (int i = 0; i < 4; ++i) {
			AddSpriteObj ();
		}
	}
        	
	// Update is called once per frame
	void Update ()
	{
		if (isGame) {
			timer += Time.deltaTime;
			timeGame -= Time.deltaTime;
			if (timer > timeSpawn) {
				timer = 0;
				timeSpawn = Random.Range (2, 6);
				AddSpriteObj ();
			}
			if (timeGame < 0) {
				/* Варіант 1
            print("Score: " + score);
            Destroy(gameObject);
            */
				Transform[] arrTrans = GetComponentsInChildren<Transform> ();
				for (int i = 0; i < arrTrans.Length; ++i) {
					if (arrTrans [i] == transform)
						continue;
					Destroy (arrTrans [i].gameObject);
				}
				isGame = false;
				print ("Score: " + score);
			}  
		}

	}
}
