using UnityEngine;
using System.Collections;

public class LunaController : MonoBehaviour {

	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed;
	public float jumpForce = 700f;
	private Rigidbody2D rb2d;


	// Use this for initialization
	void Awake ()
	{
		maxSpeed = 5f;
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update ()
	{
		maxSpeed = maxSpeed;
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		maxSpeed = maxSpeed;
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * maxSpeed * Time.deltaTime;

		if (jump)
		{
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}
}