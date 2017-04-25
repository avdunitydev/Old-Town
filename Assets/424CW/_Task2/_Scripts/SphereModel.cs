using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModel : MonoBehaviour
{
	public Material[] materials;
	public float speed;
	public Transform target;
	//MainGO fObj;


	// Use this for initialization
	void Start ()
	{
		//fObj = GetComponentInParent<MainGO> ();
		GetComponent<MeshRenderer> ().material = materials [Random.Range (0, materials.Length)];

	}
	
	// Update is called once per frame
	void Update ()
	{
		float step = speed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards (transform.position, fObj.GetComponentInChildren<CubeModel> ().transform.position, step);
		if (Vector3.Distance (transform.position, target.position) >= 1.2f) {
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
	}
}
