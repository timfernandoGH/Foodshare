using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LogoScript : MonoBehaviour {
	public GameObject can;
	// Use this for initialization
	void Start () {
		StartCoroutine (fadein());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator fadein()
	{
		yield return new WaitForSeconds (2);
		can.SetActive (true);
		SceneManager.LoadScene (1);
	}
}
