using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning: MonoBehaviour {
	public Text WinText;
	public AudioSource musicSource;
	public bool mute; 

	// Use this for initialization
	void Start () 
	{
		musicSource = GetComponent<AudioSource>();
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
			musicSource.mute = !musicSource.mute;
		}
		
		
	}
}
