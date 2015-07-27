using UnityEngine;
using System.Collections;


<<<<<<< HEAD
namespace Scripts
{
public class Player : MonoBehaviour
	{
		private Transform Current_Pos;
		public GameObject [] weapon;

		void Start()
		{
			Current_Pos = GetComponent<Transform>();
			//GameObject instance = Instantiate (toInstantiate2, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;

		}

		void Update()
		{

		}

		//Create a switch in order to enable certain weapons once obtained.. For example if the player ineracts with specific random spawned weapon
		//Allow him to cycle to it in his inventory


	}
=======
public class Player : Hitpoints
	{
		
			

>>>>>>> origin/master
}