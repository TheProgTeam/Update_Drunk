using UnityEngine;
using System.Collections;

public class MovementNonRigid : MonoBehaviour  {

	float maxSpeed = 100f;
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 positionBullet = transform.position;

	
		Vector3 velocity = new Vector3(0,maxSpeed*Time.deltaTime,0);

			positionBullet += transform.rotation * velocity;


	}
}
