using UnityEngine;
using System.Collections;

//Inherits from Enemy_Movment in order to use flip function,speed, etc..
public class Enemy_1 : EnemyMovement {

	private Rigidbody2D E_1;



	//Get the components of the rigidbody attached to enemy
	void Start()
	{

		E_1 = GetComponent<Rigidbody2D> ();
	}

	//checking if there is wall, and the enemy is facing the opposite direction
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

    void OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls" || collider.collider.tag == "Player")
        {
            Flip();
            
        }
        
        
    }
   

	


}
