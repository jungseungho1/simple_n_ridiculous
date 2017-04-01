using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour {

//	RaycastHit hit;
//	public string levelToLoad;
	public int countdown = 0;

	float smooth = 0.5f;
	float afterAngle = 145f;
	public bool doorOpen = false;
	public GameObject sound;

	void Update () {
		if (countdown == 3) {
			Quaternion targetRotation = Quaternion.Euler (0, afterAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth * Time.deltaTime);
			doorOpen = true;
			sound.SetActive (true);
		}

//		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
//		if (doorOpen == true){
//			if (Physics.Raycast (ray, out hit) && Input.GetMouseButtonDown (0) && hit.collider == GetComponent<Collider> ()) {
//				SceneManager.LoadScene (levelToLoad);
//			}
//		}
	}
}
