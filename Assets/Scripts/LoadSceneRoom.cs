using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneRoom : MonoBehaviour {

	RaycastHit hit;
	public string levelToLoad;
//	public int countdown = 0;

//	float smooth = 0.5f;
//	float afterAngle = -195f;
//	public bool doorOpen = false;

	void Update () {
//		if (countdown == 3) {
//			Quaternion targetRotation = Quaternion.Euler (0, afterAngle, 0);
//			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth * Time.deltaTime);
//			doorOpen = true;
//		}

		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
//		if (doorOpen == true){
			if (Physics.Raycast (ray, out hit) && Input.GetMouseButtonDown (0) && hit.collider == GetComponent<Collider> ()) {
//				Debug.Log ("LoadLevel" + gameObject.name);
				SceneManager.LoadScene (levelToLoad);
				}
//		}
	}
}
