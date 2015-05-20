using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	int sceneId = 0;

	// Use this for initialization
	void Start () {
			SetupLevel ();
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void SetupLevel()
	{
		GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Renderer rend = floor.gameObject.GetComponent<Renderer> ();
		rend.material.color = Color.red;
		floor.name = GetSceneID("Floor");
		floor.transform.localScale = new Vector3 (10, .5f, 10);
		floor.transform.position = new Vector3 (0, -.5f, 0);

	}

	private string GetSceneID(string item)
	{
		return "_" + sceneId + " " + item;
		sceneId ++;
	}
}

