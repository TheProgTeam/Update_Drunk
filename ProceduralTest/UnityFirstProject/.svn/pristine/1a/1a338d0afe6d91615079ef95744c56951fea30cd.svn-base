using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Floormaker : MonoBehaviour 
{



	public static int gridSizeX =10 ;
	public static int gridSizeY= 10 ;
	public static int maxTileCount =100;
	public Transform boardHolder;   
	public List <Vector3> gridPositions = new List <Vector3> ();
	public Vector3 StartPos= new Vector3(5,5,0);
	public GameObject StartInit;





	public GameObject[] floorTiles;
	public GameObject[] actualfloorTiles;


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

		for(int x=0;x<=gridSizeX;x++)
		{
		
			for(int y = 0; y <= gridSizeY; y++)

			{
				GameObject toInstantiate = floorTiles[0];
				GameObject instance =
					Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
				instance.transform.SetParent(boardHolder);

			}


		}


	}

		//foreach (GameObject gameObject in gameObjects)
		//{
			//if ()
			//{
			//	aBool = true;
			//}
			//else
			//{
			//	aBool = false;
			//}


	//}


	void Start ()
	{
			InitialiseList();
			BoardSetup();


		GameObject instance7 =
			Instantiate (StartInit,StartPos , Quaternion.identity) as GameObject;

	}






	 
}



