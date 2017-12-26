using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
	void Start () {

	}

	void Update () {

	}

	public void DestroyHammer () {
		Debug.Log ("Destroy Hammer!!!");
		Destroy (this.gameObject);
	}
}
