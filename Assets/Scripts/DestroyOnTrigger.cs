using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour {

	public GameObject obj;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Trigger") {
//			Debug.Log("will destroy" + gameObject.name);
			Destroy (gameObject);
		}
	}
}
