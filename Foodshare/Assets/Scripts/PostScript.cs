using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostScript : MonoBehaviour {
	[SerializeField] private Sprite foodPhoto;
	[SerializeField] private GameObject postPanel;
	[SerializeField] private Image imgFood;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void click()
	{
		postPanel.SetActive (true);
		imgFood.sprite = foodPhoto;
	}
}
