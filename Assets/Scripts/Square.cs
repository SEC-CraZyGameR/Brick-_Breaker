using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	private float speed = 5.0f;

	void Update () {
		float direction = Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime;
		transform.position = new Vector2 (transform.position.x + direction, transform.position.y);
	}
}
