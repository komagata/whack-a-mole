using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
	public Vector3 startPosition;
	public float speed = 2.0f;
	public float maxDistance = 2.0f;
	string direction = "up";

	void Start () {
		transform.position = this.startPosition;
		Debug.Log (this.startPosition.y);

	}

	void Update () {
		//Debug.Log (transform.position.y);
		Debug.Log (Time.deltaTime);

		if (transform.position.y - this.startPosition.y > this.maxDistance) {
			this.direction = "down";
		}

		if (this.direction == "up") {
			transform.Translate (0, this.speed * Time.deltaTime, 0);
		} else {
			transform.Translate (0, -this.speed * Time.deltaTime, 0);
		}

		if (transform.position.y < this.startPosition.y) {
			Destroy (this.gameObject);
		}
	}
}