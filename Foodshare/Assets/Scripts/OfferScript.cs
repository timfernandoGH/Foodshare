using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OfferScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadOffer()
	{
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			SceneMan.sceneOrigin = 1;
		}
		if (SceneManager.GetActiveScene ().buildIndex == 4) {
			SceneMan.sceneOrigin = 2;
		}
		if (SceneManager.GetActiveScene ().buildIndex == 7) {
			SceneMan.sceneOrigin = 3;
		}
		SceneManager.LoadScene (5);
	}
}
