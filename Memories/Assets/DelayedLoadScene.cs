using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedLoadScene : MonoBehaviour {

	public string levelToLoad;
	public Color loadToColor = Color.black;
	public float timeToStart = 3.0f;

	// Use this for initialization
	void Start () {
		Invoke ("LoadScene1", timeToStart);
	}

	void LoadScene1 (){
		Initiate.Fade (levelToLoad, loadToColor, 5.0f);
	}
}
