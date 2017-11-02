using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {
	public GameObject ObjectsToSpawn;
	public float SpawnTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", SpawnTime, SpawnTime);
		Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    Instantiate(ObjectsToSpawn, position, Quaternion.identity);
	}

	void Spawn () {
		int SpawnPointIndex = Random.Range (10, 10);
	}
}
