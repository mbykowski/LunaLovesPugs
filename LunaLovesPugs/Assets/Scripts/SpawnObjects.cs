using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public int maxObjects = 10;
	public GameObject mushroom;
	public GameObject apple;
	public GameObject medicine;
	public GameObject pizza;
	//How far we can move the objects from one another.
	public float horizontalMin = 6.5f;
	public float horizontalMax= 14f;
	public float verticalMin = 6f;
	public float verticalMax = 12f;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
			float RandomObj = Random.Range(0, 4);
			if (RandomObj == 0) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(mushroom, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 1) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(medicine, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 2) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(pizza, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 3) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(apple, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
		}
	}
}
