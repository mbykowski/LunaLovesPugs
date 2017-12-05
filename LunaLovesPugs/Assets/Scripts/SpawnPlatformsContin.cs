using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformContin : MonoBehaviour {

	public int maxObjects = 15;

	//Bad game objects
	public GameObject platforms;

	//How far we can move the objects from one another.
	private float horizontalMin = 20;
	private float horizontalMax = 30;
	private float verticalMin = -1;
	private float verticalMax = 1;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(platforms, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
		}
	}
}
