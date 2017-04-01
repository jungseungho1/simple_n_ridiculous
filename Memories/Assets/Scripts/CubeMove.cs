using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

	public float speed;

	void Update () {

		transform.Translate (0, 0, speed); //move forward. (based on the obect's orientation)

		//rotate randomly on Y axis
		transform.Rotate (0, Random.Range (-10f, 10f), 0);

	}
}
