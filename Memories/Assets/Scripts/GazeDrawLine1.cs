using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class GazeDrawLine1 : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;
	public GameObject NextObj;
	public Material clickedMtrl;
	bool clicked = false;
	bool counted = false;

//	public string levelToLoad;
//	public Color loadToColor = Color.black;
//	public float timeToStart = 5.0f;

	void Start() {
		SetGazedAt(false);
		NextObj.SetActive (false);
	}

	public void SetGazedAt(bool gazedAt) {
		if (!clicked) {
			GetComponent<Renderer> ().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
		}
	}

	public void Clicked (){
		//		Debug.Log ("clicked!" + gameObject.name);
		NextObj.SetActive (true);
		GetComponent<Renderer> ().material = clickedMtrl;
		clicked = true;
		this.GetComponent<BoxCollider> ().enabled = false;
//		Initiate.Fade (levelToLoad, loadToColor, 3.0f);

	}
}