using UnityEngine;

public static class PlayerPrefsUtils {
	public static void SetObject<T>(string key, T obj) {
		var json = JsonUtility.ToJson( obj );
		PlayerPrefs.SetString( key, json );
	}
		
	public static T GetObject<T>(string key) {
		var json = PlayerPrefs.GetString( key );
		var obj = JsonUtility.FromJson<T>( json );
		return obj;
	}
}