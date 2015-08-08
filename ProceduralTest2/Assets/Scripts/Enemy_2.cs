using UnityEngine;
using System.Collections;

public class Enemy_2 : EnemyMovement 
{

     private static Rigidbody2D E_2;


   

    bool tL =true;

   


    Vector2 first_Pos = new Vector2(-20,0);
    Vector2 second_Pos = new Vector2(-15,0);
    Vector2 third_Pos = new Vector2 (-15,-5);
    Vector2 fourth_Pos = new Vector2 (-20,-5);

    int incre = 0;
    int incre2 = 5;
    int incre3 = 10;
    int incre4 = 15;
 

  
    
    
    // Use this for initialization
	void Start () 
    {

       
        E_2 = GetComponent<Rigidbody2D> ();
      
        

        //Four new vectors created to be later used in patrol method
      

        /*Vector2 third_Pos = new Vector2(this.transform.position.x+ 1, this.transform.position.y-1);
        Vector2 fourth_Pos = new Vector2(this.transform.position.x, this.transform.position.y-1);

*/

	}




    //Patrol Method used to make enemy move in a square like motion
    void PatrolSquare()
    {   




        if (tL)
        {

            float TheRealD = Vector2.Distance(first_Pos, second_Pos);
            float distCovered = (Time.fixedTime - incre);
            Debug.Log(distCovered);
            float fracJourney = distCovered / TheRealD;
            
            transform.position = Vector2.MoveTowards(first_Pos, second_Pos, fracJourney);

           
        


            if (transform.position.x == second_Pos.x && transform.position.y == second_Pos.y)
            {

                       

                float TheRealD2 = Vector2.Distance(second_Pos, third_Pos);
                float distCovered2 = (Time.fixedTime);
                float fracJourney2 = (distCovered2 / TheRealD2);
                transform.position = Vector2.MoveTowards(second_Pos, third_Pos, fracJourney2);



                if (transform.position.x == third_Pos.x && transform.position.y == third_Pos.y)
                {

                    float TheRealD3 = Vector2.Distance(third_Pos, fourth_Pos);
                    float distCovered3 = (Time.fixedTime - incre3);
                    float fracJourney3 = (distCovered3 / TheRealD3);
                    transform.position = Vector2.Lerp(third_Pos, fourth_Pos, fracJourney3);
                  

                    
                    if (transform.position.x == fourth_Pos.x && transform.position.y == fourth_Pos.y)
                    {
                       
                        float TheRealD4 = Vector2.Distance(fourth_Pos, first_Pos);
                        float distCovered4 = (Time.fixedTime - incre4);
                        float fracJourney4 = (distCovered4 / TheRealD4);
                        transform.position = Vector2.Lerp(fourth_Pos, first_Pos, fracJourney4);
                       
                        if(transform.position.x == first_Pos.x && transform.position.y == first_Pos.y)
                        {
                            incre =+ 10;
                            incre2 =+ 15;
                            incre3 =+ 20;
                            incre4 =+ 25;
                            //PatrolSquare();

                        }


                       
                    }

                }
            }
        }

           
     }



       /* if (T_R)
        {
            Debug.Log(second_Pos);
            float TheRealD2 = Vector2.Distance (second_Pos, third_Pos);
            Debug.Log(TheRealD2);
            float distCovered2 = (Time.fixedTime - startTime);
            float fracJourney2 = distCovered2 / TheRealD2;
            
            transform.position = Vector2.Lerp (second_Pos, third_Pos, fracJourney2);
            if (transform.position.x == third_Pos.x&&transform.position.y == third_Pos.y)
            {

                T_R = false;
            B_R = true;
            }
        }
        */
       /* else if (B_R)
        {
            float TheRealD = Vector2.Distance (third_Pos, fourth_Pos);
            float distCovered = (Time.fixedTime - startTime);
            float fracJourney = distCovered / TheRealD;
            
            transform.position = Vector2.Lerp (third_Pos,  fourth_Pos, fracJourney);
            if ((Vector2)this.transform.position == fourth_Pos)
            {
                B_R= false;
            B_L =true;
            }
        }
       else if (B_L)
        {
            float TheRealD = Vector2.Distance (fourth_Pos, first_Pos);
            float distCovered = (Time.fixedTime - startTime);
            float fracJourney = distCovered / TheRealD;
            
            transform.position = Vector2.Lerp (fourth_Pos, first_Pos, fracJourney);
            if ((Vector2)this.transform.position == first_Pos)
            {
                B_L = false;
            T_L = true;
            }

        }
*/

	








	// Update is called once per frame
	void FixedUpdate () 
    {
       
        //E_2.velocity =
            //new Vector2 (maxSpeed, E_2.velocity.y);
        //transform.position = Vector2.Lerp(first_Pos, second_Pos, Time.deltaTime);
        PatrolSquare();
        //this.transform.position = Vector2.MoveTowards(second_Pos, third_Pos, maxSpeed * Time.deltaTime);

	}






















    public override void  OnCollisionEnter2D(Collision2D collider)
        
    {
        if (collider.collider.tag == "Walls"||collider.collider.tag == "Enemy")
        {
            Flip();
            
        }
        
        
    }



}