using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
	Vector3 startPosition;
	float speed = 2.0f;
	float maxDistance = 2.0f;
	string direction = "up";

	void Start () {
		this.startPosition = transform.position;
		Debug.Log ("this.startPosition.y: " + this.startPosition.y);
	}

	void Update () {
	//Debug.Log ("direction: " + this.direction +  ", transform.position.y: " + transform.position.y + ", distance.y: " + (transform.position.y - this.startPosition.y));

		Debug.Log ("transform.position.y - this.startPosition.y: " + (transform.position.y - this.startPosition.y) + ", this.maxDistance: " + this.maxDistance);
		Debug.Log ((transform.position.y - this.startPosition.y) > this.maxDistance);
	
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