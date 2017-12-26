using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSignController : MonoBehaviour {
	public void OnClick () {
		StartCoroutine (GoToTitle());
	}

	IEnumerator GoToTitle() {
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (audioSource.clip);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene ("Title");
	}
}