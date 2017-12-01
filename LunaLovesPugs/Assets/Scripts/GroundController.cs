using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

	private Vector2 originPosition;
	private bool groundEnd;
	public GameObject ground;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		groundEnd = true;
		Spawn();
	}

	// Update is called once per frame
	void Spawn() {
		Vector2 groundPosition = originPosition + new Vector2 (198.15f, 0);
		Instantiate(ground, groundPosition, Quaternion.identity);
		originPosition = groundPosition;
	}
}
