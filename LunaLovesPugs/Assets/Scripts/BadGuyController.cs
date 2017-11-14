using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 0f;

<<<<<<< HEAD
	// Use this for initialization
	void Awake ()
	{	}

	void FixedUpdate()
=======
	void Update()
>>>>>>> a91b99699167fc0d42ba10fa9b52c3bf3f858eb7
	{
		Vector2 pos = transform.position;
		int lunaPos = GameObject.Find ("Luna").GetComponent<LunaController> ().xPOS;
		if ((int)pos.x == lunaPos) {	
			maxSpeed = 0f;			
		} else {
			maxSpeed = 4f;
		}
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Luna")) {
			Debug.Log ("collided with Luna"); //correctly displaying
			GameObject.Find("Timer").SendMessage("Finish");
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
		}
	}
}
