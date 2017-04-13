using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gazed1 : MonoBehaviour {

    public string levelToLoad;
    public Color loadToColor = Color.black;
    public Material inactiveMaterial;
	public Material gazedAtMaterial;
	bool clicked = false;

	void Start() {
		SetGazedAt(false);
	}

	public void SetGazedAt(bool gazedAt) {
		if (!clicked) {
			GetComponent<Renderer> ().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
        }
	}

    public void Clicked()
    {
        Initiate.Fade(levelToLoad, loadToColor, 3.0f);
//        SceneManager.LoadScene(levelToLoad);
    }
}