using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene0 : MonoBehaviour {

	RaycastHit hit;
	public string levelToLoad;

	void Update () {
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		if (Physics.Raycast (ray, out hit) && Input.GetMouseButtonDown (0) && hit.collider == GetComponent<Collider> ()) {
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
