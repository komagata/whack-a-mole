using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundScript : MonoBehaviour {
	private static MainSoundScript instance = null;

	public static MainSoundScript Instance {
		get {
			return instance;
		}
	}
		
	void Awake () {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
