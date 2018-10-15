using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_2 : MonoBehaviour 
{
	public int num1;
    public int num2;
    public int total;
	int total2;

    void Start()
    {
        Calculat();
    }
    public void Calculat()
    {
        Add(num1,num2);
		Subtract (num1, num2);
    }

    public void Add(int One, int Two)
    {
        total = One + Two;
		print(total);
    }
	public void Subtract(int One, int Two)
	{
		total2 = One - Two;
		print (total2);
	}
}
