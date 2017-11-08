using UnityEngine;
using System.Collections;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 3.5f;
	public Vector2 userDirection = Vector2.right;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		Vector3 pos = transform.position;
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}


	/*void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}*/

}