using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartIcon : MonoBehaviour {

	public Animator Anim;

	public void Awake()
	{
		Anim = GetComponent<Animator>();
	}
	/// <summary>
	/// This function will be responsible for sending the value to the animator.
	/// </summary>
	/// <param name="HeartValue"></param>
	public void SetHeartAnim(int HeartValue)
	{
		Anim.SetInteger("HeartHealth", HeartValue);
	}
}
