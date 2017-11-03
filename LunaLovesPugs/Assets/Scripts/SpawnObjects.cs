using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public GameObject ObjectsToSpawn;
	public float SpawnTime;

	// Use this for initialization
	void Start () {
		Invoke("Spawn", SpawnTime);
	}

	void Spawn () {
		//int SpawnPointIndex = Random.Range (10, 10);
		Vector3 position = new Vector3(Random.Range(0f, 700f), 100, 0);
    Instantiate(ObjectsToSpawn, position, Quaternion.identity);
	}
}
