using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	public CharaterMove LocalPlayer;
	public GameObject CurrentCheakPoint;
	public Rigidbody2D Player;
	public GameObject PC2;
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
		//player = FindObjectOfType<Rigidbody2D> ();		
	}
	
	public void RespawnPlayer()
	{
		StartCoroutine ("RespawnPlayerCo");
	}
	public IEnumerator RespawnPlayerCo()
	{
		// Generate Death Particale
		Instantiate (DeathParticles, Player.transform.position, Player.transform.rotation);
		// Hide Player
		//Player.enabled = false;
		PC2.SetActive(false);
		Player.GetComponent<Renderer>().enabled = false;
		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// Point penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		// Debug Message
		Debug.Log ("Player Respawn");
		// Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		// Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		// Match Players transform position
		Player.transform.position = CurrentCheakPoint.transform.position;
		// Show Player
		//Player.enabled = true;
		PC2.SetActive(true);
		Player.GetComponent<Renderer>().enabled = true;
		LocalPlayer.CurHealth = LocalPlayer.MaxHealth;
		// Spawn Particle
		Instantiate (RespawnParticle, CurrentCheakPoint.transform.position, CurrentCheakPoint.transform.rotation);
	}
}
