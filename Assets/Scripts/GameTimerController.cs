using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerController : MonoBehaviour {
	public Image CircleImage;
	public float countTime = 60.0f;

	void Update () {
		CircleImage.fillAmount -= 1.0f / countTime * Time.deltaTime;
	}
}
