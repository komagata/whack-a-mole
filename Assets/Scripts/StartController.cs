using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {
	public void OnClick () {
		Debug.Log ("CLICK!!!");
		StartCoroutine (GoToMain());
	}

	IEnumerator GoToMain() {
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (audioSource.clip);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene ("Main");
	}
}
