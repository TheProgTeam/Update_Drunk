using UnityEngine;
using System.Collections;

public class Enemy_2 : EnemyMovement 
{


    public static float movTime =4f;
    private Rigidbody2D E_2;


    // Use this for initialization
	void Start () 
    {
       
        E_2 = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {

        Timer();
        StartCoroutine("PatrolSquare()");
        //
        //stopCoroutine("PatrolSquareRight");
        //StartCoroutine("PatrolSquareDown");
        //StartCoroutine("PatrolSquareLeft");
        //StartCoroutine("PatrolSquareUp");


	}




    public void Timer()
    {
    if (movTime <= 0.00f)
    {
            movTime =4f;

        
        
       
        
    }
        else
            movTime -=Time.smoothDeltaTime;
            

       
    Debug.Log(movTime);

    }


    //IEnumerator PatrolSquareDo()
    //{
    

   // }

        IEnumerator PatrolSquare()
        {

            
      
        this.E_2.velocity =
                new Vector2(maxSpeed, E_2.velocity.y);
        yield return new WaitForSeconds(1f);
        this.E_2.velocity =
            new Vector2(this.E_2.velocity.x, -1 * maxSpeed);
        yield return new WaitForSeconds(1f);
        this.E_2.velocity =
            new Vector2(this.E_2.velocity.x, -1 * maxSpeed);
        yield return new WaitForSeconds(1f);
        this.E_2.velocity =
            new Vector2(this.E_2.velocity.x, maxSpeed);
    }
    

    public override void  OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls"||collider.collider.tag == "Enemy")
        {
            Flip();
            
        }
        
        
    }



}