using UnityEngine;
using System.Collections;


namespace Scripts
{

public class Bullet : Player {





	//private Rigidbody2D Bu2D;
	
	private Rigidbody2D Boom;

	
	
	

	 //Use this for initialization
	void Start () 
	{
		Boom = GetComponent<Rigidbody2D> ();
			Vector3 Starting_Pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 Dir = (Input.mousePosition - Starting_Pos).normalized;
			Boom.AddForce (Dir*500);
		
	}




	//When player pushes left click, instantiate a bullet object. make it travel in the direction of the mouse click
	//If bullet hits either object tagged with wall or enemy destroy bullet object

	void Update() {
			




			
		}

	//Get Bullet path from Player script "Fire1" Button
	public void Tragectory()
	{
		/*if (Physics.Raycast (ray))
			Instantiate (Projectile, ray.direction, Quaternion.identity);
		Debug.Log (Projectile.transform.localPosition);


		*/



	}

	void OnCollisionEnter2D()
	{


			Destroy (gameObject);




	}


	}




}
