using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSignController : MonoBehaviour {
	public void OnClick () {
		SceneManager.LoadScene ("Title");
	}
}