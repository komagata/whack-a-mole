﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrownController : MonoBehaviour {
	public void OnClick () {
		SceneManager.LoadScene ("Ranking");
	}
}
