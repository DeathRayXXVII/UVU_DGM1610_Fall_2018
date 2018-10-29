using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour 
{
	public int num;
	public string name;

	// Use this for initialization
	void Start () 
	{
		/*if(num == 1)
			print("Hurray you picked the lucky number one!");
		else
			print("Better luck next time :(");
	
		switch(num)
		{
			case 1:
				print("Hurray you picked" + num);
			break;
			case 3:
				print("Hurray you picked" + num);
			break;
			case 6:
				print("Hurray you picked" + num);
			break;
			case 10:
				print("Hurray you picked" + num);
			break;
			default:
				print("I dont understand" + num);
			break;
		} 
		*/
		switch (name){
			case "Jason":
				print("Welcome to camp crystal lake " + name + "- Love Mother");
			break;
			case "Michael":
				print("Welcome to Haddonfield, Ill " + name);
			break;
			case "Freddie":
				print("Welcome to Elm Street " + name);
			break;
			case "Leatherface":
				print("The stars and stripes are big at night...Deep in the heart of Texas");
			break;
			default:
				print("I dont know " + name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
