using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
<<<<<<< HEAD
	public float maxSpeed = 0f;
	private Rigidbody2D rb2d;
=======
>>>>>>> b262c436479883971bf998f56672603c2efb8daa

	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()	{

		Vector2 pos = transform.position;

		int lunaPos = GameObject.Find ("Luna").GetComponent<LunaController> ().xPOS;
		if ((int)pos.x == lunaPos || (int)pos.x > lunaPos) {
			maxSpeed = 0f;
		} else {
			maxSpeed = 4f;
		}

	//	int lunaPosY = GameObject.Find ("Luna").GetComponent<LunaController> ().yPOS;
	//	pos.y = lunaPosY+1;

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
			Destroy (other.gameObject);
		}
	}

    //Method Loads a scene by a given name encasped in quotes
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
