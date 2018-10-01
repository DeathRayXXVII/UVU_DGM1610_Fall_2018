using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour 
{
	public int PointsToAdd;

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Rigidbody2D> () == null)
			return;

		ScoreManager.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}
}
