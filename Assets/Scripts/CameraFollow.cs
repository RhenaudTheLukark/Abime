using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject Spotlight;
	private Vector3 offset; 

	// Use this for initialization
	void Start () {
		offset = transform.position - Spotlight.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Spotlight.transform.position + offset;
	}
}
