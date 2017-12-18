using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour {
	public GameObject molePrefab;
	public float diff = -2.28f;

	GameObject mole1;
	GameObject mole2;
	GameObject mole3;

	Vector3 startPosition1;
	Vector3 startPosition2;
	Vector3 startPosition3;

	void Start () {
		mole1 = Instantiate (molePrefab) as GameObject;
		startPosition1 = new Vector3 (-6.02f, -3.51f, 0);
		mole1.transform.position = startPosition1;

		mole2 = Instantiate (molePrefab) as GameObject;
		startPosition2 = new Vector3 (0.2f, -4.31f, 0);
		mole2.transform.position = startPosition2;

		mole3 = Instantiate (molePrefab) as GameObject;
		startPosition3 = new Vector3 (6.13f, -2.16f, 0);
		mole3.transform.position = startPosition3;
	}

	void Update () {
		Debug.Log (startPosition1.y);
		Debug.Log (mole1.transform.position.y);
		Debug.Log (startPosition1.y - mole1.transform.position.y);

		if (startPosition1.y - mole1.transform.position.y > diff) {
			mole1.transform.Translate (0, 0.08f, 0);
			mole2.transform.Translate (0, 0.08f, 0);
			mole3.transform.Translate (0, 0.08f, 0);
		} else {
			mole1.transform.Translate (0, -0.08f, 0);
			mole2.transform.Translate (0, -0.08f, 0);
			mole3.transform.Translate (0, -0.08f, 0);
		}
	}
}
