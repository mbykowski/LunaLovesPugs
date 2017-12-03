using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour {

	public int maxPlants;
	public int maxClouds;
	public GameObject Tree;
	public GameObject Cloud1;
	public GameObject Cloud2;
	public GameObject Cloud3;
	
	//How far we can move the objects from one another.
	public float horizontalMin;
	public float horizontalMax;
	private float verticalMin = -2.0f;
	private float verticalMax = 2.0f;

	private Vector2 originPositionTree;
	private Vector2 originPositionCloud;

	// Use this for initialization
	void Start ()
	{
		originPositionTree = transform.position;
		originPositionCloud = transform.position;
		Spawn();
	}

	private void Spawn ()
	{
		for (int i=0; i < maxPlants; i++)
		{
			Vector2 randomPosition = originPositionTree + new Vector2 (Random.Range(horizontalMin,horizontalMax), 0);
			Instantiate(Tree, randomPosition, Quaternion.identity);
			originPositionTree = randomPosition;
		}
		for (int i = 0; i < maxClouds; i++) {
			float RandomObj = Random.Range(0, 2);
			if (RandomObj == 0)
			{
				Vector2 randomPosition = originPositionCloud + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin,verticalMax));
				Instantiate(Cloud1, randomPosition, Quaternion.identity);
				originPositionCloud = randomPosition;
			}
			else if (RandomObj == 1)
			{
				Vector2 randomPosition = originPositionCloud + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin,verticalMax));
				Instantiate(Cloud2, randomPosition, Quaternion.identity);
				originPositionCloud = randomPosition;
			}
			else if (RandomObj == 2)
			{
				Vector2 randomPosition = originPositionCloud + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin,verticalMax));
				Instantiate(Cloud3, randomPosition, Quaternion.identity);
				originPositionCloud = randomPosition;
			}
		}
	}
}
