using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesH : MonoBehaviour 
{
	public int num;
	public string name;

	// Use this for initialization
	void Start () 
	{
		switch(num == 1)
		{
			case 1:
				print("You have won " + num + "cat");
			break; 
			case 2:
				print("You have won " + num + "tacos");
			break; 
			case 3:
				print("You have won " + num + "rats");
			break; 
			default:
				print("Next time :(");
			break
		}
		switch(name)
		{
			case :
			break;
			case :
			break;
			case :
			break;
			case :
			break;
			default:
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
