using UnityEngine;
using System.Collections;


public class Grid : MonoBehaviour {

    //for testing purposes
    public Transform player;
    

    public LayerMask unwalkableMask;
    //this is going to define world area that grid covers
    public Vector2 gridWorldSize;
    //how much space each individual node covers
    public float nodeRadius;
    //need 2d array to represent our grid
    //Check to see for 2D game if 2dimensions are really needed
    Node [,] grid;
    float nodeDiameter;
    int gridSizeX, gridSizeY;

void Start(){
        //how many nodes can we fit into our grid?
        nodeDiameter = nodeRadius*2;
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x/nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y/nodeDiameter);
        CreateGrid();


    }

    void CreateGrid()
    {

        grid = new Node[gridSizeX, gridSizeY];
        Vector2 worldBottomLeft = (Vector2)transform.position - Vector2.right * gridWorldSize.x/2 - Vector2.up * gridWorldSize.y/2;

        for (int x =0; x<gridSizeX; x++)
        {
            for (int y= 0; y<gridSizeY; y++)
            {
                Vector2 worldPoint = worldBottomLeft + Vector2.right * (x* nodeDiameter + nodeRadius) + Vector2.up * (y*nodeDiameter + nodeRadius);
                //In Order for this bool to be triggered objects must be put in before runtime. Doesn't Update
                bool walkable = !Physics2D.OverlapCircle(worldPoint,nodeRadius,unwalkableMask);

                grid[x,y] = new Node(walkable,worldPoint);


              
            }

        }


    }
    public Node NodeFromWorldPoint (Vector2 worldPosition)
    {
        float percentX = (worldPosition.x +gridWorldSize.x/2)/gridWorldSize.x;
        float percentY = (worldPosition.y +gridWorldSize.y/2)/gridWorldSize.y;
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);
        //If posistion is  outside of the grid we won't get the error invalid index^

        int x = Mathf.RoundToInt((gridSizeX -1)* percentX);
        int y= Mathf.RoundToInt((gridSizeY-1)*percentY);

        return grid[x,y];



       

    }

//At the moment this method show us 
void OnDrawGizmos(){

        Gizmos.DrawWireCube(transform.position, new Vector2(gridWorldSize.x,gridWorldSize.y));

        if (grid != null)
        { 
            Node playerNode = NodeFromWorldPoint(player.position);

            foreach(Node n in grid)
            {
               

                Gizmos.color = (n.walkable)?Color.white:Color.red;
                if(playerNode ==n){
                    Gizmos.color = Color.cyan;
                }
                Gizmos.DrawCube(n.worldPosistion, Vector2.one * (nodeDiameter - .1f));

            }
        }
    }


}
