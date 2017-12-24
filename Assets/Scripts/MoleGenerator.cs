using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour {
	public GameObject molePrefab;

	Mole mole1;
	float interval1;
	Mole mole2;
	float interval2;
	Mole mole3;
	float interval3;

	void Start () {
		

//		this.mole1 = CreateMole (new Vector3 (-6.02f, -3.51f, 0));
//		Debug.Log ("mole1: " + this.mole1);
		//Mole mole2 = CreateMole (new Vector3 (0.2f, -4.31f, 0));
		//qMole mole3 = CreateMole (new Vector3 (6.13f, -2.16f, 0));
	}

	void Update () {
		this.interval1 += Time.deltaTime;
		this.interval2 += Time.deltaTime;
		this.interval3 += Time.deltaTime;

		if (this.mole1 == null) {
			float timing = Random.Range(3.0f, 18.0f);
			if (this.interval1 > timing) {
				this.mole1 = CreateMole (new Vector3 (-6.02f, -3.51f, 0));
				this.interval1 = 0.0f;
			}

		}

		if (this.mole2 == null) {
			float timing = Random.Range(3.0f, 18.0f);
			if (this.interval2 > timing) {
				this.mole2 = CreateMole (new Vector3 (0.2f, -4.31f, 0));
				this.interval2 = 0.0f;
			}

		}
			
		if (this.mole3 == null) {
			float timing = Random.Range(3.0f, 18.0f);
			if (this.interval3 > timing) {
				this.mole1 = CreateMole (new Vector3 (6.13f, -2.16f, 0));
				this.interval3 = 0.0f;
			}

		}
	}

	Mole CreateMole (Vector3 position) {
		return Instantiate (this.molePrefab, position, Quaternion.identity).GetComponent<Mole>();
	}
}
