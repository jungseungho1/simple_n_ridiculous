using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnTrigger : MonoBehaviour {

	public string levelToLoad;
	public Color loadToColor = Color.black;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player"){
			Initiate.Fade(levelToLoad, loadToColor, 3.0f);
		}
	}
}
