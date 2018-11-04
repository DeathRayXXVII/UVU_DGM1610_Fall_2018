using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesH : MonoBehaviour 
{
	public int num;
	public string nameChest;
	public string name;
	

	// Use this for initialization
	void Start () 
	{
		switch(num)
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
			break;
		}
		switch(nameChest)
		{
			case "Wood Chest":
				print("In side You found 15 SP");
			break;
			case "Silver Chest":
				print("In side you found 15 GP");
			break;
			case "Gold Chest":
				print("In side you found 15 PP");
			break;
			case "Double Chest":
				print("You find Magical sword in side");
			break;
			default:
				print("You found a used rag.");
			break;
		}
		switch(name)
		{
			case "sleep":
				print("Good Night");
			break;
			case "wake":
				print("Good Morning");
			break;
			default:
				print("I dont think you exist?");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
