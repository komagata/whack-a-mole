using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerGenerator : MonoBehaviour {
	public GameObject hammerPrefab;
	Hammer hammer;

	void Start () {
		//AnimatorStateInfo stateInfo = hammerPrefab.GetComponent<Animator>.GetCurrentAnimatorStateInfo (0);
		//this.animator = GetComponent<Animator> ();



	}

	void Update () {
		if (Input.GetMouseButton (0)) {
			Debug.Log ("CLICK!!");
			if (this.hammer == null) {
				this.hammer = Instantiate (this.hammerPrefab, new Vector3 (0.2f, -4.31f, 0), Quaternion.identity).GetComponent<Hammer>();
			}
		}
	}
}
