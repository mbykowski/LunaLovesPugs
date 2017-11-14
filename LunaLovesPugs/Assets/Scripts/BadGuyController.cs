using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 4f;

	void Update()
	{
		Vector2 pos = transform.position;
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Luna")) {
			Debug.Log ("collided with Luna"); //correctly displaying
			GameObject.Find("Timer").SendMessage("Finish");
            //Loads Scene Game Over
            LoadScene("GameOver");
        }
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
		}
	}

    //Method Loads a scene by a given name encasped in quotes
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
