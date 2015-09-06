using UnityEngine;
using System.Collections;

public class Node : IHeapItem<Node>{

    //nodes have two states either walkable or not
	public bool walkable;
    //essential to know what point this node represents
    public Vector2 worldPosistion;

    public int gridX;
    public int gridY;

    public int gCost;
    public int hCost;
    public Node parent;
    int heapIndex;

    //constructor assign these values when we create a node
    public Node (bool _walkable, Vector2 _worldPos, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPosistion = _worldPos;
        gridX = _gridX;
        gridY= _gridY;


    }


    //because we always have to set fCost through the addition of gcost and hcost its better to use get method
    public int fCost{
    get{
        return gCost +hCost;

    }
    }

    public int HeapIndex{

        get{
            return heapIndex;
        }

        set{
            heapIndex = value;

        }
    }
    public int CompareTo(Node nodeToCompare){
        int compare = fCost.CompareTo(nodeToCompare.fCost);
        if(compare ==0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);

        }
        return -compare;
    }

}
