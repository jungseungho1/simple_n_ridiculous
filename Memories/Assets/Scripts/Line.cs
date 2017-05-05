using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

	public GameObject gameObject1;          // Reference to the first GameObject
	public GameObject gameObject2;          // Reference to the second GameObject
	public float lineWidth = 0.05f;
	public Material lineMat;
	private LineRenderer line;                           // Line Renderer

	// Use this for initialization
	void Start () {
		// Add a Line Renderer to the GameObject
		line = this.gameObject.AddComponent<LineRenderer>();
		// Set the width of the Line Renderer
		line.SetWidth(lineWidth, lineWidth);
		// Set the number of vertex fo the Line Renderer
		line.SetVertexCount(2);
		line.material = lineMat;

	}

	// Update is called once per frame
	void Update () {
		// Check if the GameObjects are not null
		if (gameObject1 != null && gameObject2 != null)
		{
			// Update position of the two vertex of the Line Renderer
			line.SetPosition(0, gameObject1.transform.position);
			line.SetPosition(1, gameObject2.transform.position);
		}
	}
}