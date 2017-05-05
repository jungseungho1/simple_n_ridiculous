using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GazeDrawLine : MonoBehaviour {

//    public string levelToLoad;
    public Material inactiveMaterial;
	public Material gazedAtMaterial;

	public GameObject insObject;
	public GameObject insLine;

	bool completed = false;

	void Start() {
		insLine = GameObject.Find("ConnectedLine");
		SetGazedAt(false);
		completed = false;
	}

	void Update () {

	
		if (completed) {
				GameObject Player = GameObject.Find("Player");
				LoadSceneDreamGame loadScript = Player.GetComponent<LoadSceneDreamGame>();
				loadScript.countdown ++;
		}
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer> ().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
	}
	// Update is called once per frame
	public void Clicked()
	{

		if(!insObject.activeSelf)
		{
			insObject.SetActive(true);

//			LineRenderer lineRenderer = insLine.GetComponent<LineRenderer>();
//			int posNum = lineRenderer.numPositions;
//			lineRenderer.SetVertexCount(posNum+1);
//			lineRenderer.SetPosition(posNum, new Vector3(insObject.transform.position.x, insObject.transform.position.y, insObject.transform.position.z));
			this.GetComponent<BoxCollider> ().enabled = false;
		}

		if(insObject.transform.name == "PaperCraneSmall" && !completed)
		{
//			LineRenderer lineRenderer = insLine.GetComponent<LineRenderer>();
//			int posNum = lineRenderer.numPositions;
//			lineRenderer.SetVertexCount(posNum+1);
//			lineRenderer.SetPosition(posNum, new Vector3(-9f, 15f, 4f));		

			completed = true;
		}

	}


}