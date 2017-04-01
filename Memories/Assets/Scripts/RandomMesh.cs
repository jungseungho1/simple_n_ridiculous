using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;

public class RandomMesh : MonoBehaviour {

	public GameObject plane;
	Mesh mesh;
	List<Vector3> verts = new List<Vector3> ();
	public float jitterRange = 0.3f;

	// Use this for initialization
	void Start () {
		mesh = plane.GetComponent<MeshFilter> ().mesh;
		UpdateVertices ();
	}

	void UpdateVertices(){
		verts.Clear ();

		for (int i = 0; i < mesh.vertexCount; i++)
		{
			Vector3 newPos = mesh.vertices [i];
			newPos.y += Random.Range (-jitterRange, jitterRange);
			newPos.y += (0 - newPos.y) * 0.12f;
			verts.Add (newPos);
		}

		mesh.SetVertices (verts);
		mesh.RecalculateNormals ();

	}


	// Update is called once per frame
	void Update () {
		UpdateVertices ();

		//update collider with mesh pos.
		plane.GetComponent<MeshCollider> ().sharedMesh = null;
		plane.GetComponent<MeshCollider> ().sharedMesh = plane.GetComponent<MeshFilter>().mesh;

	}
}
