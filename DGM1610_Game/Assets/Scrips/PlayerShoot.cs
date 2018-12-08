﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	//Shoot variables
	public Transform FirePoint;
	public GameObject projectile;
	public CharaterMove LocalPlayer;
	private float PowerTime;

	// Use this for initialization
	void Start () 
	{
		projectile.SetActive(false);
		projectile = Resources.Load("Prefab/Fireball") as GameObject;	
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.LeftShift))
			Instantiate(projectile,FirePoint.position, FirePoint.rotation);
		
		//if(PowerUpCounter <= 0)
		//{
		//	projectile.SetActive(false);
		//}
		
	}
}
