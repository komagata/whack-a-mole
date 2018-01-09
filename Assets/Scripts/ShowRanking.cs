using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanking : MonoBehaviour {
	void Start () {

		Ranking ranking = RankingDataStore.GetRanking ();
		Debug.Log (ranking);

		ranking.points.Sort((a, b) => b - a);

		if (ranking.points.Count <= 5) {
			int rest = 5 - ranking.points.Count;
			for (int i = 0; i < rest; i++) {
				ranking.points.Add (5 - i);
			}
		}

		ranking.points.Sort((a, b) => b - a);

		string text = "";
		for (int i = 0; i < ranking.points.Count; i++) {
			text += i + 1 + ". " + ranking.points[i] + "てん\n";
		}

		Text rankingText = GetComponent<Text> ();
		rankingText.text = text;
	}
}
