﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour {

	public string levelToLoad;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player"){
			SceneManager.LoadScene (levelToLoad);
		}
	}
}