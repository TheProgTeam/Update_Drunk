using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour {
    
    public List <GameObject> enemyPatrol = new List <GameObject> ();
    public List <GameObject> enemyBox = new List <GameObject> ();
    public List <GameObject> enemyDiag = new List <GameObject> ();
    public List <GameObject> enemyRand = new List <GameObject> ();


    private int enemyNum = 2;
    private int findFloor;
    public GameObject Player;

   
   



	
	void Start () 
    {

       
        Enemy1Spawner(enemyNum);
        PlayerSpawner();
       

	}
    void Update()
    {

    }
	
	

    //enemy has to take in the level
    //Spawns Enemy Patrollers
    void Enemy1Spawner(int enemyTot)
    {


        
        for(int i=0; i<enemyTot;i++)
        {
            findFloor = Random.Range(0, 625);
            // Floormaker.multiTiles[findFloor] =  
            if (Floormaker.multiTiles[findFloor].CompareTag("Floors"))
            {
                
                
                if(Floormaker.multiTiles[findFloor+Floormaker.gridSizeX].CompareTag("Floors"))
                { 
                    Instantiate (enemyPatrol[0],Floormaker.multiTiles[findFloor].transform.position, Quaternion.identity);
                }
                
                
                else if(Floormaker.multiTiles[findFloor- Floormaker.gridSizeX].CompareTag("Floors"))
                {
                    
                    Instantiate (enemyPatrol[0],Floormaker.multiTiles[findFloor].transform.position, Quaternion.identity);
                    
                }
                else if (Floormaker.multiTiles[findFloor- (Floormaker.gridSizeX*2)].CompareTag("Floors"))
                {
                    Instantiate (enemyPatrol[0],Floormaker.multiTiles[findFloor].transform.position, Quaternion.identity);
                }
                else if (Floormaker.multiTiles[findFloor+ (Floormaker.gridSizeX*2)].CompareTag("Floors"))
                {
                    Instantiate (enemyPatrol[0],Floormaker.multiTiles[findFloor].transform.position, Quaternion.identity);
                }
                
                
                
                
                
            }
            else
                enemyTot++;
            
        }
        
    }


    //spawns Player
    void PlayerSpawner()
    {
        if (Player !=null)
        {
            Instantiate (Player,new Vector3(0,0,0), Quaternion.identity);

        }


    }




    }



