using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanking : MonoBehaviour {
	void Start () {
		List<int> rankings = new List<int>();

		rankings.Add(5);
		rankings.Add(4);
		rankings.Add(10);
		rankings.Add(2);
		rankings.Add(1);

		rankings.Sort ((a, b) => b - a);

		string text = "";
		for (int i = 0; i < rankings.Count; i++) {
			text += i + 1 + ". " + rankings [i] + "てん\n";
		}

		Text rankingText = GetComponent<Text> ();
		rankingText.text = text;
	}
}
