using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayActivate : MonoBehaviour {

	public GameObject crane;
	// Use this for initialization
	void Start () {
		crane.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("craneAct", 10f);
	}

	void craneAct (){
		crane.SetActive (true);
	}
}
