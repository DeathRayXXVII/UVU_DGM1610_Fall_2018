using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour 
{
	public Transform[] background;
	private float[] ParallaxScales;
	public float smoothing;

	private Transform cam;
	private Vector3 previousCamPos;

	// Use this for initialization
	void Start () 
	{
		cam = Camera.main.transform;

		previousCamPos = cam.position;

		ParallaxScales = new float[background.Length];
		for(int i = 0; i < background.Length; i++)
		{
			ParallaxScales[i] = background[i].position.z * -1;
		} 	
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		for (int i = 0; i < background.Length; i++)
		{
			float parallax = (previousCamPos.x - cam.position.x) * ParallaxScales[i];
		
			float backgroundTargetPosX = background[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX,background[i].position.y, background[i].position.z);

			background[i].position = Vector3.Lerp (background[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		}	

		previousCamPos = cam.position;
	}
}
