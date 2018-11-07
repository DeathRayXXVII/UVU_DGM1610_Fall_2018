using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartIcon : MonoBehaviour {

	public Animator Anim;

	public void Awake()
	{
		Anim = GetComponent<Animator>();
	}
	public void SetHeartAnim(int HeartValue)
	{
		Anim.SetInteger("HeartHealth", HeartValue);
	}
}
