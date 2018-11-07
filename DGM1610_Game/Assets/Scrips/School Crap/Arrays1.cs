using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays1 : MonoBehaviour 
{
	public int[] RollDice = new int[12];
	public string[] DandDClasses;
	public string[] Gaming;

	// Use this for initialization
	void Start () 
	{
		DandDClasses = new string[5];
		DandDClasses[0] = "Dwarf";
		DandDClasses[1] = "Elf";
		DandDClasses[2] = "Dragonborn";
		DandDClasses[3] = "Half Elf";
		DandDClasses[4] = "Nome";

		Gaming = new string[4];
		Gaming[0] = "Playstation";
		Gaming[1] = "Switch";
		Gaming[2] = "Xbox";
		Gaming[3] = "PC";

		RollDice [0] = 1;
		RollDice [1] = 2;
		RollDice [2] = 3;
		RollDice [3] = 4;
		RollDice [4] = 5;
		RollDice [5] = 6;
		RollDice [6] = 7;
		print(RollDice[4]);
	}
}
