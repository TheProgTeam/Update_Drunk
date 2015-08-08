using UnityEngine;
using System.Collections;


//Dump all methods which could possibly be used in the future
public class Throw_Away_Functions : MonoBehaviour {

	
    /*
     * 
      public void PatrolSquare()
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

     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * /
     * 
     * 
     * 
     * 
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
     * 
     * 
     * 
     * 

*/





}
