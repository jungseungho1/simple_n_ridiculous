using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gazed1 : MonoBehaviour {

    public string levelToLoad;
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
        SceneManager.LoadScene(levelToLoad);
    }
}