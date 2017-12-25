using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
	void Start () {
		GetComponent<Animator> ().SetTrigger("isBang");
	}

	void Update () {

	}

	public void DestroyHammer () {
		Destroy (this.gameObject);
	}
}
