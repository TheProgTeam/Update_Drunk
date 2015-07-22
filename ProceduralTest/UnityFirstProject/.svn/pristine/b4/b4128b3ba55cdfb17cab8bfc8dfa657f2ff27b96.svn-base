using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class DrunkardWalk : Floormaker {

	//The Four Possible Directions
	private Vector3 north;
	private Vector3 south;
	private Vector3 east;
	private Vector3 west;
	private Transform mytransform;
	public Vector3 StartPos= new Vector3(0,0,0);
	int randtileAmount;



	int ChosenDir;


	void Awake()
	{
		mytransform = gameObject.transform;
		randtileAmount = Random.Range(30,70);

		north = new Vector3(mytransform.position.x,mytransform.position.y+1, 0f);
		south = new Vector3(mytransform.position.x,mytransform.position.y-1, 0f);
		west = new Vector3(mytransform.position.x+1,mytransform.position.y, 0f);
		east = new Vector3(mytransform.position.x-1,mytransform.position.y, 0f);




	}

	void DrunkWalk()
	{
		ChosenDir = Random.Range(0,3);




	}

	


	void Layout ()
	{
		int maxTile;
	

		
				
	
					


					GameObject toInstantiateac = actualfloorTiles[0];

					switch (ChosenDir)
				{

						case 0 :
							GameObject instance1 =
							Instantiate (toInstantiateac, north, Quaternion.identity) as GameObject;
							Debug.Log ("NORTH!");
							break;

						case 1 :
							GameObject instance2 =
							Instantiate (toInstantiateac, south, Quaternion.identity) as GameObject;
							Debug.Log ("SOUTH!");
							break;

						case 2 :
							GameObject instance3 =
							Instantiate (toInstantiateac, west, Quaternion.identity) as GameObject;
							Debug.Log ("WEST!");
							break;

						case 3 :
							GameObject instance4 =
							Instantiate (toInstantiateac, east, Quaternion.identity) as GameObject;
							Debug.Log ("EAST!");
							break;
				
				}
			
	}
			

		


	// Use this for initialization
	void Start () {

		DrunkWalk();
		Layout();



	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//instance1.transform.SetParent(boardHolder);
}
