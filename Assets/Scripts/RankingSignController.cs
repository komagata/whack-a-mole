﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingSignController : MonoBehaviour {
	public void OnClick () {
		SceneManager.LoadScene ("Ranking");
	}
}
