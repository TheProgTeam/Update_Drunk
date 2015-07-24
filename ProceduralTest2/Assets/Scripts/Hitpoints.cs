using UnityEngine;
using System.Collections;

public class Hitpoints : MonoBehaviour 
{

		public static int Hp;
		public static float ivTimer = 0;
		
		private Transform findZwall;
		public GameObject Wall;

		
		
		
		// Use this for initialization
		void Start ()
		{
			//initialize HP
			Hp = 5;
		findZwall = GameObject.FindGameObjectWithTag("Walls").transform;
		findZwall = GetComponent<Transform>();
		//Wall = GameObject.FindGameObjectsWithTag("Walls");	
			
		}
		
		// Update is called once per frame
		void Update ()
		{


			ivTimer -= Time.deltaTime;
			//Debug.Log (ivTimer);
			if (Hp == 0) 
			{
				Destroy (gameObject);
			}
			
			
			
			
		}
		
		
		public static void LoseHipoints()
		{


			if (ivTimer <= 0){
				
				--Hp;
				
				Debug.Log ("Hotpoints equals= " +Hp);
				ivTimer = 1f;
				
			}
			
			
		}
		void OnCollisionEnter2D()
	{

			if(Wall.tag=="Walls")
		{
			return;
		}

		Hitpoints.LoseHipoints ();
		
		
	}
		
	}

