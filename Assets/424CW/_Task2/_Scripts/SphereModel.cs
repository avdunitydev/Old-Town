using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModel : MonoBehaviour
{
	public Material[] materials;
	public float speed;
	CubeModel target;
	MainGO fObj;


	// Use this for initialization
	void Start ()
	{
		fObj = GetComponentInParent<MainGO> ();
		//MeshRenderer<material>()= materials [Random.Range (0, materials.Length)];
	}
	
	// Update is called once per frame
	void Update ()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, fObj.GetComponentInChildren<CubeModel> ().transform.position, step);
	}
}
