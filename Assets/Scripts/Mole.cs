using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
	void Start () {
	}

	void Update () {
	}

//	public void TurnRight () {
//		Vector3 localScale = transform.localScale;
//		localScale.x = -1;
//		transform.localScale = localScale;
//	}
//
//	public void TurnLeft () {
//		Vector3 localScale = transform.localScale;
//		localScale.x = 1;
//		transform.localScale = localScale;
//	}

	public void DestroyMole () {
		Debug.Log ("Destroy Mole!!!");
		Destroy (this.gameObject);
	}
}