using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour {
	public GameObject molePrefab;

	Mole mole1;
	Mole mole2;
	Mole mole3;

	void Start () {
		this.mole1 = Instantiate(this.molePrefab).GetComponent<Mole>();
		mole1.startPosition = new Vector3 (-6.02f, -3.51f, 0);

		this.mole2 = Instantiate(this.molePrefab).GetComponent<Mole>();
		mole2.startPosition = new Vector3 (0.2f, -4.31f, 0);

		this.mole3 = Instantiate(this.molePrefab).GetComponent<Mole>();
		mole3.startPosition = new Vector3 (6.13f, -2.16f, 0);
	}

	void Update () {

	}
}
