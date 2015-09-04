using UnityEngine;
using System.Collections;

public class AstarPsuedo : MonoBehaviour {

	/*

     Open (List of all the open nodes)
     Closed (List of all the closed nodes)
     add the starting point node to OPEN

    Loop
    current = node in OPEN with lowest f_cost
    remove current from OPEN
    add current to CLOSED

    if current is the target node //PATH HAS BEEN FOUND
    return

    foreach neighbour of the current node 
        if neighbour is not travesable or neighbour is in CLOSED
            skip to the next neighbour

    if new path to neighbour is shorter OR neighbour is not in OPEN 
        set f_cost of neighbour
        st parent of neighbour to current 
        if neighbour is not in OPEN
            add neighbour to OPEN



*/

}
