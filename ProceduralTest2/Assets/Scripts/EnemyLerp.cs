using UnityEngine;
using System.Collections;
namespace Scripts{

public class EnemyLerp:Movement
	{

	private Rigidbody2D em2D;
		private float startTime=1;




		Transform Target;

		public float rotSpeed = 180f;
	




	// Use this for initialization
	void Start () 
		{
		em2D = GetComponent<Rigidbody2D> ();
			Target = GetComponent<Transform> ();


	}
		//void Update()
		//{

		//}
		void Update()
		{

			GameObject asshole = GameObject.FindGameObjectWithTag("Follow");
			Target =asshole.transform;
			Vector2 posa = asshole.transform.position;
			if (asshole ==  true) {
				//if (Chris.Vector2.x =5)
				
				Vector2 peter = new Vector2 (0, 0);
				Vector2 Chris = new Vector2 (5, 0);
				float TheRealD = Vector2.Distance (peter, posa);

				transform.position = peter;
				float distCovered = (Time.time - startTime) * 1;
				float fracJourney = distCovered / TheRealD;

				transform.position = Vector2.Lerp(peter,Chris , Time.deltaTime);
				em2D.AddForce (Vector2.Lerp(peter,Chris,fracJourney));

				transform.position = Vector2.Lerp (peter, posa, fracJourney);
			}

			else {
				Debug.Log("The Target no longer exist, and has  been destroyed");
			}


			
			Vector2 direct = Target.position - transform.position;
			direct.Normalize();

			float zAngle = Mathf.Atan2(direct.y,direct.x)* Mathf.Rad2Deg +90;
			Quaternion desiredRot = Quaternion.Euler(0,0,zAngle);
			transform.rotation= Quaternion.RotateTowards(transform.rotation,desiredRot,rotSpeed* Time.deltaTime);

		}

	//void FixedUpdate()
		//{


	//}
	
	

	
	
		}


	


}







