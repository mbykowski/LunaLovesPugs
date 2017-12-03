using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformsContin : MonoBehaviour {

	public int maxPlatforms;
	public GameObject platform;
	private float horizontalMin = 6.5f;
	private float horizontalMax = 14f;
	private float verticalMin = 0f;
	private float verticalMax = 5f;
	private Vector2 originPosition;
	public GameObject Luna;
	float posMin = 300.0f;
	float posMax = 400.0f;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn ();
	}

	void Update()
	{
		if(Luna.transform.position.x >= posMin && Luna.transform.position.x <= posMax) {
			//maxPlatforms += 50;
			posMin += 250.0f;
			posMax += 250.0f;
			Spawn();
		}
	}

	void Spawn(){
		for (int i = 0; i < maxPlatforms; i++) {
			if (i < 4) {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(0, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			} else {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			}
		}

	}
}
