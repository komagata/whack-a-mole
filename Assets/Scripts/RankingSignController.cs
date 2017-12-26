using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingSignController : MonoBehaviour {
	public void OnClick () {
		StartCoroutine (GoToRanking());
	}

	IEnumerator GoToRanking() {
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (audioSource.clip);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene ("Ranking");
	}
}
