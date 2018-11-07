using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPieces : MonoBehaviour {

	public HeartUI HeartUI;

	public int HeartPieceAmount;

	void Start()
	{
		GetComponent<BoxCollider2D>().isTrigger = true;
		HeartUI = FindObjectOfType<HeartUI>();
	}

	void OnTriggerEnter2D(Collider2D Other)
	{
		if (Other.tag == "Player")
		{
//			HeartUI.AddHeartPiece(HeartPieceAmount);
			Destroy(gameObject);
		}
		
			
	}
}
