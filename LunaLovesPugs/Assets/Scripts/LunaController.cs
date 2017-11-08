using UnityEngine;
using System.Collections;

public class LunaController : MonoBehaviour {

	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 700f;
	private Rigidbody2D rb2d;
	private CircleCollider2D collider;


	// Use this for initialization
	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D>();
		collider= GetComponent<CircleCollider2D> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * maxSpeed * Time.deltaTime;

		if (jump)
		{
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("PickUp"))
			Destroy (gameObject);
	}


}
