using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gazed0 : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;
    public string levelToLoad;
    public Color loadToColor = Color.black;
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