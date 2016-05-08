using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject player;
	//so we reference the player on the inspector
	private Vector3 offset;
	//so we can calculate distance between player and camera
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
		//on lateUpdate because here goes the animation thingies ¿?
	{
		transform.position = player.transform.position + offset;
	}
}
