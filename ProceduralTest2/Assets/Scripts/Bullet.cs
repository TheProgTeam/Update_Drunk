using UnityEngine;
using System.Collections;

public class Bullet : Weapons {





	//private Rigidbody2D Bu2D;
	public GameObject[] bulletPrefab;

	
	
	
	// Use this for initialization
	void Start () 
	{
		Tragectory ();
		//Bu2D = GetComponent<Rigidbody2D> ();
		
	}




	//When player pushes left click, instantiate a bullet object. make it travel in the direction of the mouse click
	//If bullet hits either object tagged with wall or enemy destroy bullet object

	void Update() {


			
		}

	//Get Bullet path from Player script "Fire1" Button
	void Tragectory()
	{
		if (Physics.Raycast (ray))
			Instantiate (Projectile, ray.direction, Quaternion.identity);
		Debug.Log (Projectile.transform.localPosition);
		
	}

	void OnCollisionEnter2D()
	{

		Destroy (bulletPrefab [0]);




	}





}
