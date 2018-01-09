using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingDataStore {
	static string KEY = "RANKING";

	public static Ranking GetRanking() {
		string json = PlayerPrefs.GetString(RankingDataStore.KEY);
		if (json == "") {
			return new Ranking ();
		} else {
			Ranking ranking = JsonUtility.FromJson<Ranking>(json);
			return ranking;
		}
	}

	public static void AddPoint(int point) {
		Ranking ranking = RankingDataStore.GetRanking ();

		ranking.points.Add (point);

		string json = JsonUtility.ToJson(ranking);
		Debug.Log ("JSON STRING: " + json);
		PlayerPrefs.SetString(RankingDataStore.KEY, json);
		PlayerPrefs.Save ();
	}
}