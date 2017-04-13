using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour {

	public string levelToLoad;
    public Color loadToColor = Color.black;

    void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player"){
            Initiate.Fade(levelToLoad, loadToColor, 3.0f);
//            SceneManager.LoadScene (levelToLoad);
		}
	}
}
