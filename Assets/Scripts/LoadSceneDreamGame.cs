using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneDreamGame : MonoBehaviour {

	RaycastHit hit;
	public string levelToLoad;
	public int countdown = 0;

	void Update () {
		if (countdown == 3) {
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
