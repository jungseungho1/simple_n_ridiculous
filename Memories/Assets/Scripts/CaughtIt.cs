using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtIt : MonoBehaviour {

	public GameObject Explosion;
	public GameObject Fire;
	bool Exploded = false;
	public GameObject createThis;
	private Vector3 random;
	public GameObject sound;

	void Awake () {
		foreach (MeshRenderer mr in this.GetComponentsInChildren<MeshRenderer>()) {
			mr.enabled = true;
		}
			
		foreach (Light lite in this.GetComponentsInChildren<Light>()) {
			lite.enabled = true;
		}
			
		foreach (ParticleSystem ps in this.GetComponentsInChildren<ParticleSystem>()) {
			ps.Play ();
		}

		foreach (MonoBehaviour ps in this.GetComponentsInChildren<MonoBehaviour>()) {
			ps.enabled = true;

		}
	}

	void Update () {
		
		random = new Vector3 (Random.Range(-20F,20F), Random.Range(10F,20F), Random.Range(-20F,20F));
//		If the it has already exploded, destory it as soon as all of the various particles it has emitted are gone.
		if (Exploded) {
			
			int particleCount = 0;
			foreach (ParticleSystem ps in this.GetComponentsInChildren<ParticleSystem>()) {
				particleCount += ps.particleCount;
			}

			if (particleCount == 0) {
				Destroy (this.gameObject);
				Instantiate(createThis, random, Quaternion.identity);

				GameObject Player = GameObject.Find("Player");
				LoadSceneDreamGame loadScript = Player.GetComponent<LoadSceneDreamGame>();
				loadScript.countdown ++;

			}
		}
	}

	void OnTriggerEnter(Collider caught) {

		
		if (caught.gameObject.tag == "Player") {
			
			// Disable the mesh renderers of the object to make the it dissappear.
			foreach (MeshRenderer mr in this.GetComponentsInChildren<MeshRenderer>()) {
				mr.enabled = false;
			}

			// Disable its lights.
			foreach (Light lite in this.GetComponentsInChildren<Light>()) {
				lite.enabled = false;
			}

			// Stop the particle systems it has. The particles that have already been emitted will remain.
			foreach (ParticleSystem ps in this.GetComponentsInChildren<ParticleSystem>()) {
				ps.Stop ();
			}

			// Instantiate the explosion and the prefab
			Instantiate (Explosion, this.transform.position, Quaternion.identity);
			Instantiate (Fire, this.transform.position, Quaternion.identity);

			Exploded = true;
			sound.SetActive (true);
		}
	}
}
