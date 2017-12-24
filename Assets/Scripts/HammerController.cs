using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour {
	void Start () {
		//AnimatorStateInfo stateInfo = hammerPrefab.GetComponent<Animator>.GetCurrentAnimatorStateInfo (0);

		Animator animator = GetComponent<Animator> ();
		animator.SetTrigger ("isBang");
	}

	void Update () {
		
	}
}
