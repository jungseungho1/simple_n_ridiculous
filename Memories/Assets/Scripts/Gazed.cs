using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gazed : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;
	public GameObject particles;
	public Material clickedMtrl;
	bool clicked = false;
	bool counted = false;

	void Start() {
		SetGazedAt(false);
		particles.SetActive (false);
	}

	public void SetGazedAt(bool gazedAt) {
		if (!clicked) {
			GetComponent<Renderer> ().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
		}
	}

	public void Clicked (){
//		Debug.Log ("clicked!" + gameObject.name);
		particles.SetActive (true);
		GetComponent<Renderer> ().material = clickedMtrl;
		clicked = true;

		GameObject Door = GameObject.Find("Door");
		OpenDoor loadScript = Door.GetComponent<OpenDoor>();

		if (!counted) {
			loadScript.countdown++;
			counted = true;
		}

	}
}