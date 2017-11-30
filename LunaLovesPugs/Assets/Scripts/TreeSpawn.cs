using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour {

	public int maxObjects;
	public GameObject Tree;

	//How far we can move the objects from one another.
	public float horizontalMin;
	public float horizontalMax;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), 0);
				Instantiate(Tree, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
	}
}
