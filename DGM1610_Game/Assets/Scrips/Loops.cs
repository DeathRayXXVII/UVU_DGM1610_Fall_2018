using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour 
{
	public int Num = 40;
	public string Color  = "Blue";

	// Use this for initialization
	void Start () 
	{
		// for(int i = 0; i <= 100;  i++ )
		// {
		// 	print(i + "Ants Marching");
		// }
		while(Num > 0)
		{
			print ("Countdown"+Num);
			Num --;
		}
		// while( Color == "Red")
		// {
		// 	print("Color is" + Color);
		// }
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
