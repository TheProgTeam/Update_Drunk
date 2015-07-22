using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Floormaker : MonoBehaviour 
{



	public static int gridSizeX =50 ;
	public static int gridSizeY= 50 ;
	public static int maxTileCount =100;
	public static int CURRENT_CASE = 1225;

	public List <GameObject> wallTiles = new List <GameObject> ();
	public List <GameObject> floorTiles = new List <GameObject> ();
	public List <Vector3> gridPositions = new List <Vector3> ();

	
	int randtileAmount;
	int ChosenDir;






	public GameObject[] wallPrefabTiles;
	public GameObject[] floorPrefabTiles;




	void InitialiseList()
	{
		gridPositions.Clear();

		for(int x=1;x<=gridSizeX;x++)
		{
			for(int y = 1; y <= gridSizeY; y++)
			{
				gridPositions.Add (new Vector3(x, y, 0f));


			}

		}
	}
		void BoardSetup ()
	{

		for(int x=0;x < gridSizeX;x++)
		{
		
			for(int y = 0; y < gridSizeY; y++)

			{
				GameObject toInstantiate = wallPrefabTiles[0];
				wallTiles.Add (Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject);

			}


		}
	}

		void FloorSetup ()
		{
			
			for(int x=0;x < gridSizeX;x++)
			{
				
				for(int y = 0; y < gridSizeY; y++)
					
				{
					GameObject toInstantiate2 = floorPrefabTiles[0];
					GameObject instance =
					Instantiate (toInstantiate2, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
				floorTiles.Add (instance);
					
				}
				
				
			}


	}

		
	void StartingPos()
	{	


		//Destroy (wallTiles[550]);
		 


	}





	void DrunkWalk()
	{

		
		for(int x = 0;x<=randtileAmount;x++)
		{
			
			ChosenDir = Random.Range(0,3);
			Debug.Log(ChosenDir);


			

			switch (ChosenDir)
			{
				//WEST
			case 0:
				#pragma warning disable
				for (int i=0;i<gridSizeX-1;i++)
				{if ((CURRENT_CASE-gridSizeX) <=i) {
					randtileAmount++;
					goto case 4;
					}
						else{
							break;
					}
				}

				CURRENT_CASE -=gridSizeX;
				Destroy(wallTiles[CURRENT_CASE]);
				break;
				//EAST
			case 1:

				for( int i = ((gridSizeX*gridSizeX)-gridSizeX);i<=(gridSizeX*gridSizeX);i++){


					if ((CURRENT_CASE+gridSizeX)<= i)
				{
					randtileAmount++;
					goto case 4;
				}
					else 
						break;


				}
				CURRENT_CASE += gridSizeX;
				Destroy(wallTiles[CURRENT_CASE]);
				break;
				//NORTH
			case 2:

				for(int i= gridSizeX; i<=((gridSizeX*gridSizeX)); )
				    {
					i+=gridSizeX;
					if ((CURRENT_CASE+gridSizeX)>= i)
				{
					randtileAmount++;
					goto case 4;
				}
					else
						break;
				}
				CURRENT_CASE +=1;
				Destroy(wallTiles[CURRENT_CASE]);
				break;
				//SOUTH
			case 3:
				for(int i= 0; i<=((gridSizeX*gridSizeX)-(gridSizeX)); )
				{
					i+=gridSizeX;
					if ((CURRENT_CASE+gridSizeX)<= i)
					{
						randtileAmount++;
						goto case 4;
					}
					else
						break;
				}

				CURRENT_CASE -=1;
				Destroy(wallTiles[CURRENT_CASE]);
				break;	
				#pragma warning restore
			case 4:
				break;
				
				
			}
		}
		
	}



	void Awake ()
	{	
		randtileAmount = Random.Range(750,1000);
		Debug.Log (randtileAmount);

		BoardSetup();
		FloorSetup();
		DrunkWalk();

			//InitialiseList();
			
			 



	}

	void Start()
	{

		StartingPos();

	}




	 
}



