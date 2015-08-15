using UnityEngine;
using System.Collections;

public class Enemy_2 : EnemyMovement 
{

     private Rigidbody2D E_2;
       

   

   
    static bool T_L =true;
    bool T_R = false;
    bool B_R = false;
    bool B_L = false;

    /*
    These Are the variables that we can use in this enemy+
    
    public float maxSpeed = 1.5f;
    public Transform Player;
    public float MaxDist = 10f;
    public float MinDist = 2f;
    private float Dist;

     */

    /*
    At the moment big issue is if the enemies path is obstructed, no exception is called
    Create a method that  moves enemy right left up or down and re-intialized the 4 positions
    if theres a collison

    In other words throw the vectors into our OnCollison2D vectors or create a method, as mentioned before
    */


    //Creating 4 Vectors to define Movement
    Vector3 first_Pos;// = new Vector3(-20,0,0);
    Vector3 second_Pos;// = new Vector3(-15,0,0);
    Vector3 third_Pos;// = new Vector3 (-15,-5,0);
    Vector3 fourth_Pos; // = new Vector3 (-20,-5,0);


    //Dimensions of square
    private int dimX = 2;
    private int dimY = 2;



    // Use this for initialization
	void Start () 
    {

       
        E_2 = GetComponent<Rigidbody2D> ();
      
        

        //Four new vectors created to be later used in patrol method
        //Make a method to clean the start method up
      
        first_Pos = new Vector3(this.transform.position.x,this.transform.position.y,0);
        second_Pos = new Vector3(this.transform.position.x+ dimX, this.transform.position.y,0);
        third_Pos = new Vector3(this.transform.position.x+ dimX,this.transform.position.y - dimY,0);
        fourth_Pos = new Vector3(this.transform.position.x,this.transform.position.y - dimY,0);




	}




    //Patrol Method used to make enemy move in a square like motion
    void PatrolSquare()
    {   

        //using distance we will trigger bools 

        //NEVER COMPARE FLOATING POINT NUMBERS
               
        if (T_L)
        {
           
            Dist = Vector3.Distance(transform.position,second_Pos);

            if (Dist < 0.09)
            {

                this.E_2.velocity = new Vector2(0 ,0);
            T_L = false;
            T_R = true;
            }
            else
                
                this.E_2.velocity =
                    new Vector2 (maxSpeed, E_2.velocity.y);
        }

        else if (T_R)
        {
            Dist = Vector3.Distance(transform.position,third_Pos);
          
           
            if (Dist < 0.09)
            {
                this.E_2.velocity = new Vector2(0,0);
                T_R= false;
            B_R =true;
            }
            else
                this.E_2.velocity =
                    new Vector2 (E_2.velocity.x, maxSpeed*-1);
        }
       else if (B_R)
        {        
            Dist = Vector3.Distance(transform.position,fourth_Pos);
            if (Dist < 0.09)
            {
                this.E_2.velocity = new Vector2(0,0);
                B_R = false;
            B_L = true;
            }
            else
                this.E_2.velocity =
                    new Vector2 (maxSpeed*-1, E_2.velocity.y);


        }
        else if (B_L)
        {        
           
            Dist = Vector3.Distance(transform.position,first_Pos);
            if (Dist < 0.09)
            {
                this.E_2.velocity = new Vector2(0,0);
                B_L = false;
                T_L = true;
            }
            else
                this.E_2.velocity =
                    new Vector2 (E_2.velocity.x, maxSpeed);
            
        }



    }
	








	// Update is called once per frame
	void Update () 
    {
       PatrolSquare();

	}

    void FixedUpdate()
    {







    }





    public override void  OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls"||collider.collider.tag == "Enemy")
        {
            Flip();


            first_Pos = new Vector3(this.transform.position.x,this.transform.position.y,0);
            second_Pos = new Vector3(this.transform.position.x+ dimX, this.transform.position.y,0);
            third_Pos = new Vector3(this.transform.position.x+ dimX,this.transform.position.y - dimY,0);
            fourth_Pos = new Vector3(this.transform.position.x,this.transform.position.y - dimY,0);

            
        }


        
        
    }

   

}