using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadCal()
	{
		SceneManager.LoadScene (1);
	}

	public void loadMap()
	{
		SceneManager.LoadScene (2);
	}

	public void loadPost()
	{
		SceneMan.sceneOriUni = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (3);
	}

	public void loadDeals()
	{
		SceneMan.sceneOriUni = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (8);
	}
}
