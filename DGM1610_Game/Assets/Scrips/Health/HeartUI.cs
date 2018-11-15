using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HeartUI : MonoBehaviour {
 
	public CharaterMove LocalPlayer;

	public List<HeartIcon> HeartIcons;

	public int HeartPieces;

	public int MaxHeartsContainer = 20;

	public GameObject HeartUIPiece;

    private int DrawHeartPieces;

	public void Start()
	{
		UpdateHearts();
	}
	/// <summary>
	/// This function will be resposible for redrawing the list  and keeping track of current health and max health.
	/// </summary>
	void UpdateHearts()
	{
		HeartIcons = GetComponentsInChildren<HeartIcon>().ToList();
		LocalPlayer = FindObjectOfType<CharaterMove>();
		LocalPlayer.MaxHealth = ( HeartIcons.Count ) * 4;
		LocalPlayer.CurHealth = LocalPlayer.MaxHealth;
	}
	public void Update()
	{
		DrawHearts();
	}
	/// <summary>
	/// This function is responsible for adding the heart pieces when picked up in game.
	/// </summary>
	/// <param name="_HeartsPiecesToAdd"></param>
	public void AddHeartPiece(int HeartsPiecesToAdd)
	{
		if (HeartIcons.Count >= MaxHeartsContainer)
			return;

		HeartPieces += HeartsPiecesToAdd;

		if (HeartPieces - 4 >= 0 )
		{
			GameObject TempObject = Instantiate(HeartUIPiece, Vector3.zero, Quaternion.identity) as GameObject;

			TempObject.transform.SetParent(this.transform);

			HeartPieces -= 4;
			
			UpdateHearts();
		}
	}
	/// <summary>
	/// This is the function resposible for drawing the hearts and sending information to their animators.
	/// </summary>
	void DrawHearts()
	{
		//We will get the amount of hearts in the list and count to them in a loop
		for (int i = 1; i < HeartIcons.Count + 1; i++)
		{
			//We store the value of the pieces of heart in the last partial filled heart
			DrawHeartPieces = LocalPlayer.CurHealth % 4;
			//If the current heart container is full 
			if (LocalPlayer.CurHealth >= i * 4)
			{
				//Set the heart to full
				HeartIcons[i - 1].SetHeartAnim(4);
			}
			else
			{
				//If the heartis empty set the image to empty
				if (( LocalPlayer.CurHealth - ( ( i - 1 ) * 4 ) ) <= 0)
					HeartIcons[i - 1].SetHeartAnim(0);
				else
				{
					//Debug.Log("The value being sent to the heart " + i + "  is " + _HeartPieces);

					//If none of the above the heart must be partially full so fill it
					HeartIcons[i - 1].SetHeartAnim(DrawHeartPieces);
				}
			}
		}
	}
}
