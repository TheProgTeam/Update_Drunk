using UnityEngine;
using System.Collections;

public class Hitpoints : MonoBehaviour 
{

		public  int Hp =0;
		public  float ivTimer = 0;

		
		 
		// Use this for initialization
		void Start ()
		{
			//initialize HP
			 Hp = 5;
	
		}
		
		// Update is called once per frame
		void Update ()
		{

		//Ivtimer I set in the inspector and if it is 5 then it is not player therefore IVTIMER will not work
		if (ivTimer!=5)
		{
			ivTimer -= Time.deltaTime;

		}
		if (Hp == 0) 
		{
			Destroy (gameObject);
		}	
			
			
		}
		
		
		


	public  void LoseHipoints()
		{

		if (ivTimer <= 0)
		{
			
			--Hp;
			
			Debug.Log ("Player HP: " +Hp);
			ivTimer = 1f;
			
		}
			

		//IVtimer 5 will make the invulnerability timer not work when set in inspector
			if (ivTimer ==5)
			{

			--Hp;
			Debug.Log ("HP: " +Hp);
			}

			
		}
	public  void OnCollisionEnter2D(Collision2D collision)
	{
		//This makes sure that gameobject does not lose hp from walls and to make sure that the enemies don't lose hp from hitting player
	
			if(collision.gameObject.tag == "Walls" || collision.gameObject.tag == "Player")
		{
	
			return;

		
		}
		LoseHipoints();

	}
   
    public  void OnCollisionStay2D(Collision2D collision)
    {
        //This makes sure that gameobject does not lose hp from walls and to make sure that the enemies don't lose hp from hitting player
        
        if(collision.gameObject.tag == "Walls" || collision.gameObject.tag == "Player")
        {
            
            return;
            
            
        }
        LoseHipoints();
        
    }

//Since we use hitpoints script to change hitpoints on enemies through the use of the ontrigger option on the gameobjects being instantiated
public  void OnTriggerEnter2D(Collider2D collider)
{
	//This makes sure that gameobject does not lose hp from walls and to make sure that the enemies don't lose hp from hitting player
	
	if(collider.gameObject.tag == "Walls" || collider.gameObject.tag == "Player")
	{
		
		return;
		
		
	}
	LoseHipoints();
	
}

}
	
