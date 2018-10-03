using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	public GameObject CurrentCheakPoint;
	private Rigidbody2D player;
	// Particles
	public GameObject DeathParticles;
	public GameObject RespawnParticle;
	// Respawn Delay
	public float RespawnDelay;
	// Point Penalty on Death
	public int PointPenaltyOnDeath;
	// Store Gravity Value
	private float GravityStore;

	// Use this for initialization
	void Start () 
	{
		player = FindObjectOfType<Rigidbody2D> ();		
	}
	
	public void RespawnPlayer()
	{
		StartCoroutine ("RespawnPlayerCo");
	}
	public IEnumerator RespawnPlayerCo()
	{
		//Generate Death Particale
		Instantiate (DeathParticles, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enabled = false;
		player.GetComponent<Renderer>().enabled = false;
		//Gravity Reset
		GravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = vector2.zero;
		// Point penalty
	}

}
