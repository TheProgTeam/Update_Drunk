using UnityEngine;
using System.Collections;

//Inherits from Enemy_Movment in order to use flip function,speed, etc..
public class Enemy_1 : EnemyMovement {

	private Rigidbody2D E_1;
    private Transform E_1T;
    Vector3 playerPOS;
    bool checkLeftFlip = true;
    bool checkRightFlip = true;
    [SerializeField]
    private GameObject[] bulletPrefaber;


 

    /*
    These Are the variables that we can use in this enemy+
    
    public float maxSpeed = 1.5f;
    public Transform Player;
    public float MaxDist = 10f;
    public float MinDist = 2f;
    private float Dist;

     */


	//Get the components of the rigidbody attached to enemy
	void Start()
	{
       
		E_1 = GetComponent<Rigidbody2D> ();

        //E_1T = GetComponent<Transform> ();


	}

	//checking if there is wall, and the enemy is facing the opposite direction
	void Update()
	{
        if(Player !=null){

            Player = GameObject.FindGameObjectWithTag("Player");
            playerPOS =  Player.transform.position;
            Patrol();
            Chase();





        }




       
        
    }

    void Chase()
    {
        //In order not to have Unity scream at me and hurt my feelings I check if there is an object (Player) 
        if (Player != null)
    {
        
        //Dist is used to calculate the distance between the player and the enemy 
        Dist = Vector2.Distance(transform.position, playerPOS);
        //if and only if dist is less than min distance I make the enemy lerp using the MoveTowords method. Its similar to lerp but has an extra argument in it to slow down the movement
        if (Dist < MinDist)
        {
            /*Quaternion rotation = Quaternion.LookRotation
                    (Player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
                transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);*/
            
            
            
            transform.position = Vector2.Lerp(transform.position, playerPOS, maxSpeed * Time.deltaTime);
           //if(transform.position.x-Player.transform.position.x<0 || transform.position.x > Player.transform.position.x) 
            
            
            
        }
            if(Player.transform.position.x > transform.position.x && checkLeftFlip == true)
                {
                    Flip();
                    checkRightFlip = true;
                    isFacingRight = true;
                    

                }
            if(Player.transform.position.x < transform.position.x && checkRightFlip == true)
                {
                    Flip();
                    checkLeftFlip=true;
                    isFacingRight = false;
                    
                }
    }
    }
    

    //new Vector2(transform.position.x, transform.position.y)

     void Patrol()
        {
        
          if (this.isFacingRight == true) 
            {
			this.E_1.velocity =
				new Vector2 (maxSpeed, E_1.velocity.y);

		    } 
            else 
            {
			this.E_1.velocity =
				new Vector2 (maxSpeed * -1, this.E_1.velocity.y);


		    }
       }




    public override void   OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls" ||collider.collider.tag == "Enemy")
        {
            Flip();
            
        }
       
        
    }
   

	


}
