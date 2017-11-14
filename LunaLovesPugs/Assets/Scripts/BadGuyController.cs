using UnityEngine;
using System.Collections;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 0f;

	// Use this for initialization
	void Awake ()
	{	}

	void FixedUpdate()
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
			//Tiffany this is where the game over screen will need to be called
		}
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
		}
	}
}
