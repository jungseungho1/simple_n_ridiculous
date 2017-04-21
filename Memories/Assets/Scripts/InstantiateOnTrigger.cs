using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnTrigger : MonoBehaviour {

	public GameObject CreateThis;
//	public Vector3 CreateHere;
	public Transform CreateHere1;
	public bool alreadyPlayed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (!alreadyPlayed) {
			if (other.gameObject.tag == "Player") {
//				Instantiate (CreateThis, CreateHere, Quaternion.identity);
				Instantiate (CreateThis, CreateHere1.position, CreateHere1.rotation );
			}
		}
	}


}
