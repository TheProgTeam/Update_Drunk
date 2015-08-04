using UnityEngine;
using System.Collections;

public class Enemy_1 : EnemyMovement {

	private Rigidbody2D E_1;

	void Start()
	{

		E_1 = GetComponent<Rigidbody2D> ();
	}

	//checking if there is wall, and if there is face the opposite direction
	void FixedUpdate()
	{
		if (this.isFacingRight == true) {
			this.E_1.velocity =
				new Vector2 (maxSpeed, E_1.velocity.y);

		} else {
			this.E_1.velocity =
				new Vector2 (maxSpeed * -1, this.E_1.velocity.y);


		}
	}

	void OnTriggerEnter2D (Collider2D collider)
		
	{

		if (collider.tag == "Walls")
		{
			Flip();
		
		}


	}


}
