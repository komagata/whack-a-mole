using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerController : MonoBehaviour {
	public GameObject gameover;
	public Text point;
	public Image CircleImage;
	public float countTime = 5.0f;
	public static bool isFinish = false;
	float totalTime = 0.0f;

	List<int> rankings = new List<int>();

	void Start() {
		this.rankings.Add (12);
		this.rankings.Add (5);
		this.rankings.Add (4);
		this.rankings.Add (2);
		this.rankings.Add (8);
	}

	void Update () {
		this.totalTime += Time.deltaTime;

		if (CircleImage.fillAmount > 0) {
			if (this.totalTime > 3.5f) {
				CircleImage.fillAmount -= 10.0f / countTime * Time.deltaTime;
			}
		} else {
			if (GameTimerController.isFinish == false) {
				AudioSource audioSource = GetComponent<AudioSource> ();
				audioSource.PlayOneShot (audioSource.clip);
				this.point.text = Score.point + "てん";
				this.gameover.SetActive (true);

				this.rankings.Add (Score.point);
				PlayerPrefsUtils.SetObject ("RANKING", this.rankings);

				GameTimerController.isFinish = true;
			}
		}
	}
}