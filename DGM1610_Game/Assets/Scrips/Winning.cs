using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning: MonoBehaviour {
	public Text WinText;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//if player hits the Escape key return to start menu
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}
	void OnTriggerEnter2D(Collider2D Other)
	{
		//if the plalyer win display win text
		if(Other.tag == "Player")
		{
			print("Win Score Reached = ");
			WinText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		
		
	}
}
