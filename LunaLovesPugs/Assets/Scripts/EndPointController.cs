using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPointController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Luna")) {
			Debug.Log ("collided with Luna"); //correctly displaying
			GameObject.Find("Timer").SendMessage("Finish");
			//Loads Scene Game Over
			LoadScene("Win");
		}
		if (other.gameObject.CompareTag ("GoodPickUp") || other.gameObject.CompareTag ("BadPickUp")) {
			Destroy (other.gameObject);
		}
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
