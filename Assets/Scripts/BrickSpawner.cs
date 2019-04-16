using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour {

	public GameObject brickPrefabs;
	private Vector3 pos;
	private float tempPos;

	void Start () {
		pos = transform.position;
		tempPos = transform.position.x;
		spawnBrick ();
	}

	public void spawnBrick()
	{
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				GameObject go = Instantiate (brickPrefabs, pos, Quaternion.identity);
				pos.x += 1.1f;
			}
			pos.y -= .5f;
			pos.x = tempPos;
		}
	}
}
