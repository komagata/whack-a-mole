using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
	ParticleSystem particle;

	void Start () {
		this.particle = GetComponent<ParticleSystem> ();
		this.particle.Stop ();
	}

	void Update () {
		if (GameTimerController.isFinish == true) {
			DestroyMole ();
		}
	}

	public void TurnRight () {
		Vector3 localScale = transform.localScale;
		localScale.x = -1;
		transform.localScale = localScale;
	}

	public void TurnLeft () {
		Vector3 localScale = transform.localScale;
		localScale.x = 1;
		transform.localScale = localScale;
	}

	void OnMouseDown() {
		Destroy (GetComponent<CircleCollider2D> ());

		Score.point++;
		GetComponent<Animator>().SetTrigger("isDamege");
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (audioSource.clip);
		this.particle.Play ();
	}

	public void DestroyMole () {
		Debug.Log ("Destroy Mole!!!");
		Destroy (this.gameObject);
	}
}