using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homwork2 : MonoBehaviour 
{

	private string spectral;

	// Use this for initialization
	void Start () 
	{
		if(spectral == "Wakes Up")
			print ("Good morning" + spectral);
		else if (spectral == "Sleeping")
			print ("Good Night" + spectral);
		else if (spectral == "Zoning")
			print (spectral + " is Day Dreaming");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
