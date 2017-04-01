using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnTrigger : MonoBehaviour {

	float smooth = 0.2f;
	float afterAngle = -195f;
//	float beforeAngle = 0f;
	bool inBucket;

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Trigger")
		{
			inBucket = true;
		}
	}


	// Update is called once per frame
	void Update () {
		if (inBucket == true){
			Quaternion targetRotation = Quaternion.Euler(0, afterAngle, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
//		} else {
//			Quaternion targetRotation2 = Quaternion.Euler(0, beforeAngle, 0);
//			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
		}
	}
}
