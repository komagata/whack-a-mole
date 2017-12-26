using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour {
	public GameObject molePrefab;
	Mole[] moles = new Mole[3];
	Vector3[] positions = new Vector3[3];
	float[] intervals = new float[3];

	void Start () {
		this.positions [0] = new Vector3 (-6.02f, -4.1f, 0);
		this.positions [1] = new Vector3 (0.2f, -4.8f, 0);
		this.positions [2] = new Vector3 (6.13f, -2.45f, 0);
	}

	void Update () {
		for(int i = 0; i < moles.Length; i++) {
			this.intervals[i] += Time.deltaTime;

			if (this.moles[i] == null) {
				float timing = Random.Range (3.0f, 20.0f);
				if (this.intervals[i] > timing) {
					this.moles[i] = Instantiate (this.molePrefab, this.positions[i], Quaternion.identity).GetComponent<Mole> ();
					this.intervals[i] = 0f;

					if (Random.Range(0, 2) == 0) {
						this.moles[i].TurnLeft ();
					} else {
						this.moles[i].TurnRight ();
					}
				}

			}
		}
	}
}