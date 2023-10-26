using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player;

	// Start is called before the first frame update
	void Start()
	{

	}



	// Update is called once per frame
	void Update()
	{


	}
	


	public Vector3 offset = new Vector3 (0f, 2f, -5f);
	// The LateUpate is where we should put script execution because it tracks object that moved inside update!
	void LateUpdate()
	{
		
		// Sets the Poisition of the camera onto the player
		transform.position = player.transform.position + offset;
	}
	
}
