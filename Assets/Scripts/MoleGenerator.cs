using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour {
	public GameObject molePrefab;

	float timer;

	void Start () {
		Mole mole1 = CreateMole (new Vector3 (-6.02f, -3.51f, 0));
		//Mole mole2 = CreateMole (new Vector3 (0.2f, -4.31f, 0));
		//qMole mole3 = CreateMole (new Vector3 (6.13f, -2.16f, 0));
	}

	void Update () {
		this.timer += Time.deltaTime;
	}

	Mole CreateMole(Vector3 position) {
		GameObject prefabMole = Instantiate (this.molePrefab, position, Quaternion.identity);
		Debug.Log(prefabMole.transform.position);
		return prefabMole.GetComponent<Mole>();
	}
}
