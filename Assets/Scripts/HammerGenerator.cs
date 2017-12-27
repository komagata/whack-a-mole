using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerGenerator : MonoBehaviour {
	public Image circleImage;
	public GameObject hammerPrefab;
	Hammer hammer;

	void Start () {
	}

	void Update () {
		if (Input.GetMouseButton (0)) {
			CreateHammer ();
		}
	}

	void CreateHammer () {
		if (GameTimerController.isFinish == false) {
			if (this.hammer == null) {
				Vector3 clickPos = Input.mousePosition;
				clickPos.x += 60.0f;
				clickPos.y += 50.0f;
				clickPos.z = 10f;
				Vector3 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
				this.hammer = Instantiate (this.hammerPrefab, worldPos, Quaternion.identity).GetComponent<Hammer>();
			}
		}
	}
}
