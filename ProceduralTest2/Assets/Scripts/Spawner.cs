using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Spawner : Floormaker {


    public List <GameObject> enemyPatrol = new List <GameObject> ();
    public List <GameObject> enemyBox = new List <GameObject> ();
    public List <GameObject> enemyDiag = new List <GameObject> ();
    public List <GameObject> enemyRand = new List <GameObject> ();

    private int findFloor;
    private GameObject peter;




	
	void Start () 
    {

       // peter = gameObject.
	}
	
	

    //enemy has to take in the level

   /* void Enemy1Spawner()
    {


        findFloor = Random.Range(0, randtileAmount);
       // multiTiles[findFloor] =  
        if (multiTiles[findFloor].CompareTag("Floors"))
        {



        }


    }

*/
}
