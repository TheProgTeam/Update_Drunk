﻿using UnityEngine;
using System.Collections;

public class Hitpoints : MonoBehaviour 
{
	[SerializeField]
		public static int Hp =0;
		public static float ivTimer = 0;
		
		private Transform findZwall;
		public GameObject wall;
		public GameObject player;

		
		
		
		// Use this for initialization
		void Start ()
		{
			//initialize HP
			 Hp = 5;

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


			if (ivTimer <= 0)
			{
				
				--Hp;
				
				Debug.Log ("Hotpoints equals= " +Hp);
				ivTimer = 1f;
				
			}
			
			
		}
	public virtual void OnCollisionEnter2D()
	{
		if(player.tag=="Player")
		{
			if(wall.tag!="Walls")
			{
				Hitpoints.LoseHipoints ();
			}

		
		}
		else
		{
			Hitpoints.LoseHipoints ();
		}
		 
			
	}
	
		
	}
