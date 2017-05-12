using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnTrigger : MonoBehaviour {

	public GameObject GvrFPSCanvas;
	public GameObject carCrash;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			GvrFPSCanvas.SetActive (false);
			carCrash.SetActive (true);
		}
	}
}
