using UnityEngine;
using System.Collections;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 4f;

	// Use this for initialization
	void Awake ()
	{	}

	void Update()
	{
		Vector3 pos = transform.position;
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}
	void OnTriggerEnter2D(Collider2D other)
	{ 
		if (other.gameObject.CompareTag ("Luna")) {
			Debug.Log ("collided with Luna"); //correctly displaying
			//Tiffany this is where the game over screen will need to be called
		}
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
		}
	}
}