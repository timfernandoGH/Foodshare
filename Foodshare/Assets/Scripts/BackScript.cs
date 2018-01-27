using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadBack()
	{
		if (SceneMan.sceneOrigin == 1) {
			SceneManager.LoadScene (2);
		}
		if (SceneMan.sceneOrigin == 2) {
			SceneManager.LoadScene (4);
		}
		if (SceneMan.sceneOrigin == 3) {
			SceneManager.LoadScene (7);
		}
	}
}
