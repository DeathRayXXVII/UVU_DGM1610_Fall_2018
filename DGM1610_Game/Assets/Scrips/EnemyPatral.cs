using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatral : MonoBehaviour 
{
	// Movement Variables
	public float MoveSpeed;
	public bool MoveRight;

	// Wall Check
	public Transform WallCheck;
	public floatWall CheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

	// Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
