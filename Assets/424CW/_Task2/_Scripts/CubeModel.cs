using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModel : MonoBehaviour
{
	public Material[] materials;
	public Transform[] path;
	public float speed;
	int i;


	// Use this for initialization
	void Start ()
	{
		//speed = 1.2f;
		GetComponent<MeshRenderer> ().material = materials [Random.Range (0, materials.Length)];
		i = 0;

	}
	
	// Update is called once per frame
	void Update ()
	{
		float step = speed * Time.deltaTime;

		if (Vector3.Distance (transform.position, path [i].position) >= 0.02f) {
			transform.position = Vector3.MoveTowards (transform.position, path [i].position, step);
		} else if (i < path.Length - 1) {
			++i;
		} else if (i == path.Length - 1) {
			i = 0;

		}

	}
}
