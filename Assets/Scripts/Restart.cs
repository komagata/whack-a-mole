using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public GameObject gameover;

	public void OnClick () {
		StartCoroutine (GoToMain());
	}

	IEnumerator GoToMain() {
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (audioSource.clip);
		yield return new WaitForSeconds(0.5f);
		GameTimerController.isFinish = false;
		this.gameover.SetActive (false);
		SceneManager.LoadScene ("Main");
	}
}
