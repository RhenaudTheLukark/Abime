using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Horizontal") * speed;

		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 180;
		transform.rotation = Quaternion.Euler(angle,-90,0);

		transform.position += new Vector3 (translation, 0, 0);

	}
}
