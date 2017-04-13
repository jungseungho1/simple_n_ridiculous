using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneDreamGame : MonoBehaviour {

	RaycastHit hit;
	public string levelToLoad;
    public Color loadToColor = Color.black;
    public int countdown = 0;

	void Update () {
<<<<<<< HEAD
//		if (countdown == 3) {
		if (countdown == 1) {
			SceneManager.LoadScene (levelToLoad);
=======
		if (countdown >= 1) {
            Initiate.Fade(levelToLoad, loadToColor, 3.0f);
//            SceneManager.LoadScene (levelToLoad);
>>>>>>> v4.5
		}
	}
}
