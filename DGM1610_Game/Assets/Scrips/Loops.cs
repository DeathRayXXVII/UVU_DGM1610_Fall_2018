using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour 
{
	public int num = 40;

	// Use this for initialization
	void Start () 
	{
		// for(int i = 0; i <= 100;  i++ )
		// {
		// 	print(i + "Ants Marching");
		// }
		while(num > 0)
		{
			print ("Countdown"num);
			num --;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
