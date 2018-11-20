using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour {

	[SerializeField]
	private int health;

	public CharaterMove LocalPlayer;

	void OnTriggerEnter2D(Collider2D Other)
	{
		if (Other.tag == "Player")
		{
			//Player.MyInstance.MyHealth.CurHealth += health;
			LocalPlayer.CurHealth += health;
			Destroy(gameObject);
		}	
	}
}
