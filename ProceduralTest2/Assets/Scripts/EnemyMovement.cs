using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	//In order not to see these variables in the children of enemy movement I used the following
	[HideInInspector]
	public bool isFacingRight = false;
	public float maxSpeed = 1.5f;
    public Transform Player;
    public float MaxDist = 10f;
    public float MinDist = 2f;
    public float Dist;

    



	//The Flip function inverts the value of isfacingright bool and then flips the transform of the enemy
	//Game Object
	public void Flip()
	{
		isFacingRight = !isFacingRight;
		Vector3 enemyScale = this.transform.localScale;
		enemyScale.x = enemyScale.x * -1;
		this.transform.localScale = enemyScale;


	}

    void Start()
    {

    }
    void Update()

    {


    }


    public virtual void  OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls")
        {
            Flip();
            
        }
        
        
    }

	
}

