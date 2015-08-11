using UnityEngine;
using System.Collections;



namespace Scripts
{
public class Player : MonoBehaviour
	{
		private Transform Current_Pos;
		//public GameObject [] weapon;
		private Rigidbody2D Pl2D;
		public GameObject[] bulletPrefab1;
		//public Vector3 Dir;



		void Start()
		{
			Current_Pos = GetComponent<Transform>();
			Pl2D = GetComponent <Rigidbody2D> ();
			//Instantiate (weapon[0],Current_Pos.position, Quaternion.identity);




			//GameObject instance = Instantiate (toInstantiate2, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;

		}

		void Update()
		{
			if (Input.GetButtonDown("Fire1"))
			    {

				//GameObject toInstantiate2 = bulletPrefab1[0];
				Instantiate (bulletPrefab1[0],Current_Pos.position, Quaternion.identity);


				//Pl2D.AddForce (Dir*200);
			}

		}

		//Create a switch in order to enable certain weapons once obtained.. For example if the player ineracts with specific random spawned weapon
		//Allow him to cycle to it in his inventory


	}




}