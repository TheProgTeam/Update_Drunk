using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Floormaker : MonoBehaviour 
{



	public static int gridSizeX =25 ;
	public static int gridSizeY= 25 ;
	public static int maxTileCount =100;
	public static int CURRENT_CASE = 1;
   
    public List <GameObject> multiTiles = new List <GameObject>();
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

	//Generates Wall Tiles
		void BoardSetup ()
	{

		for(int x=0;x < gridSizeX;x++)
		{
		
			for(int y = 0; y < gridSizeY; y++)

			{	
			
				GameObject toInstantiate = wallPrefabTiles[Random.Range(0,wallPrefabTiles.Length)];
				multiTiles.Add (Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject);


			}


		}
	}
	void OuterWall()

	{
		for(int x=-1;x <= gridSizeX;x++)
		{
			
			for(int y = -1; y <= gridSizeY; y++)
				
			{	
				if(x == -1 || x == gridSizeX|| y == -1 || y == gridSizeY)

				{
					GameObject toInstantiate2 = wallPrefabTiles[Random.Range(0,wallPrefabTiles.Length)];
					GameObject instance = Instantiate (toInstantiate2, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
				}
			else
				{
				
				}
				
			}
			
			
		}




	}




	

		
	void StartingPos()
	{	


		//Destroy (multiTiles[550]);
		 


	}





	void DrunkWalk()
	{
        GameObject toInstantiate2 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
        Destroy(multiTiles[CURRENT_CASE]);
        multiTiles.Add (Instantiate (toInstantiate2,multiTiles[CURRENT_CASE].transform.position , Quaternion.identity) as GameObject);

		
		for(int x = 0;x<=randtileAmount;x++)
		{
			
			ChosenDir = Random.Range(0,4);
			//Debug.Log("Direction Chosen: "+ChosenDir);


			

			switch (ChosenDir)
			{
				//WEST
			case 0:


				//For loop checks to see if number goes past the barrier to the left. If it does, stop and revert number
				for (int i=0;i<gridSizeX-1;i++)
				{

					if ((CURRENT_CASE-gridSizeX) <i) 
					
					
					{
					randtileAmount++;
					goto case 4;
					}
						

				}



				CURRENT_CASE -=gridSizeX;
				if (CURRENT_CASE<=0)
				{
					CURRENT_CASE=+gridSizeX;
					randtileAmount++;
					goto case 4;
				}
                    GameObject toInstantiate3 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
                    multiTiles.Add (Instantiate (toInstantiate3,multiTiles[CURRENT_CASE].transform.position , Quaternion.identity) as GameObject);
				Destroy(multiTiles[CURRENT_CASE]);
                  

                    //GameObject toInstantiate2 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
                    //floorTiles.Add (Instantiate (toInstantiate2, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject);
				break;


				//EAST
			 case 1:
				//Case 1 goes right therefore we want our for loop to start at the element which is at the bottom of the last row and stop at the last element generated

				for( int i = ((gridSizeX*gridSizeX)-gridSizeX);i<=(gridSizeX*gridSizeX-1);i++)
				
				
				{


					if ((CURRENT_CASE+gridSizeX)> (gridSizeX*gridSizeX-1))
					{
					randtileAmount++;
					goto case 4;
					}
			


				}


				CURRENT_CASE += gridSizeX;

				if (CURRENT_CASE>(gridSizeX*gridSizeX-1))
				{
					CURRENT_CASE=-gridSizeX;
					randtileAmount++;
					goto case 4;
				}
                    GameObject toInstantiate4 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
                    multiTiles.Add (Instantiate (toInstantiate4,multiTiles[CURRENT_CASE].transform.position , Quaternion.identity) as GameObject);
				Destroy(multiTiles[CURRENT_CASE]);
				break;
				//NORTH
			case 2:

				for(int i= gridSizeX-1; i<=((gridSizeX*gridSizeX)-1);i+=gridSizeX )

				{	

					if ((CURRENT_CASE) == i)
					{
					randtileAmount++;
					goto case 4;
					}
				//	Debug.Log ("I is:"+i);



				}

				
				CURRENT_CASE +=1;
                    GameObject toInstantiate5 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
                    multiTiles.Add (Instantiate (toInstantiate5,multiTiles[CURRENT_CASE].transform.position , Quaternion.identity) as GameObject);
				Destroy(multiTiles[CURRENT_CASE]);
				break;
				//SOUTH
			case 3:

				for(int i= 0; i<=((gridSizeX*gridSizeX)-(gridSizeX));i+=gridSizeX)
				{

					if ((CURRENT_CASE-1)== i)
					{
						randtileAmount++;
						goto case 4;
					}

				}

				CURRENT_CASE -=1;
                    GameObject toInstantiate6 = floorPrefabTiles[(Random.Range(0,floorPrefabTiles.Length))];
                    multiTiles.Add (Instantiate (toInstantiate6,multiTiles[CURRENT_CASE].transform.position , Quaternion.identity) as GameObject);
				Destroy(multiTiles[CURRENT_CASE]);
				break;	

			case 4:

				break;
				
				
			}
		}
		
	}



	void Awake ()
	{	
		randtileAmount = Random.Range(750,1250);
		Debug.Log ("Random Tile Amount: "+randtileAmount);

		BoardSetup();
		DrunkWalk();
		OuterWall();

			//InitialiseList();
			
			 



	}

	void Start()
	{

		StartingPos();

	}




	 
}



