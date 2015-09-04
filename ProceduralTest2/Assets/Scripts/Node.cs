using UnityEngine;
using System.Collections;

public class Node {

    //nodes have two states either walkable or not
	public bool walkable;
    //essential to know what point this node represents
    public Vector2 worldPosistion;

    //constructor assign these values when we create a node
    public Node (bool _walkable, Vector2 _worldPos)
    {
        walkable = _walkable;
        worldPosistion = _worldPos;


    }

}
