using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour 
{
		enum Inventory {Cheese, Meat , Sword, Shield, Map, Bow, Arrows, Backpack};
		
	// Use this for initialization
	void Start () 
	{
		print("Cheese" + Inventory.Cheese);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
