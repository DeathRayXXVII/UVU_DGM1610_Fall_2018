using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayQuiz : MonoBehaviour 
{
	public string[] PetOwner;
	public int hp;

	// Use this for initialization
	void Start () 
	{
		PetOwner = new string [6];
		PetOwner[0] = "Cat";
		PetOwner[1] = "Dog";
		PetOwner[2] = "Parite";
		PetOwner[3] = "Lizard";
		PetOwner[4] = "Sip";
		PetOwner[5] = "Goldfish";
		print(PetOwner[3]);

		//foreach(hp)
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
