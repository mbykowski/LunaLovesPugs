using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugObjectCollision : MonoBehaviour {

	LunaController luna = new LunaController();
	void Start () {
	}
	void Update () {		
	}
	void OnTriggerEnter2D(Collider2D other)
	{ //not totally working yet (doesn't appear to be reflecting on the object)
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
			if (other.gameObject.name == "Mushroom(Clone)") {
				luna.maxSpeed = (float)(luna.maxSpeed - 2);
			} else if (other.gameObject.name == "Pizza(Clone)") {
				luna.maxSpeed = (float)(luna.maxSpeed - 1);
			} else if (other.gameObject.name == "Apple(Clone)") {
				if (luna.maxSpeed == 5) {
					luna.maxSpeed = luna.maxSpeed;
				} else {
					luna.maxSpeed = (float)luna.maxSpeed + 1;
				}
			} else if (other.gameObject.name == "Medicine(Clone)") {
				if (luna.maxSpeed >= 3) {
					luna.maxSpeed = 5f;
				} else {
					luna.maxSpeed = (float)luna.maxSpeed + 2;
				}
			}  else { }
		}
	}
}
