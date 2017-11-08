using UnityEngine;
using System.Collections;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 4f;
	public Vector2 userDirection = Vector2.right;

	// Use this for initialization
	void Awake ()
	{	}

	void Update()
	{
		Vector3 pos = transform.position;
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}

}