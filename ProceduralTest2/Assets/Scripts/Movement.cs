using UnityEngine;
using System.Collections;

namespace Scripts
{
public class Movement : MonoBehaviour {

	private float maxSpeed = 3.5f;
	//float rotSpeed = 180f;
	private Rigidbody2D rb2D;
	//private Vector2 CurentPoss = new Vector2();
		private Transform posss;

		
	//GameObject Chris = new GameObject();

	void currentpos()
		{

		}


	void Start () 
	{
		//start always has getcomponents such as rigid body box collider..
		rb2D = GetComponent<Rigidbody2D> ();
			posss = GetComponent<Transform> ();

	
	}
	

	void FixedUpdate () 
	{
			//var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);

			//transform.rotation = rot;

			//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);


	

			//if (Input.GetButton("Fire2"))
		   

			//float input = Input.GetAxis("Horizontal");

			Vector2 Chris = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical")); 
			rb2D.AddForce (Chris * maxSpeed, ForceMode2D.Impulse);
			rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;

			//CurentPoss = Chris;

		}

			
		void Update()
		{



		}
		//void currentposss()
		//{

		//}


		//Vector3  Peter = transform.eulerAngles;

		//Quaternion rot = transform.rotation;

		//float z = rot.eulerAngles.z;
		//Vector3 NR = new Vector3 (0, 0, 0);
		//Vector3 LR= new Vector3(0,0,90);




		//transform.rotation = rot;







		//transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0));
		//{
		//	rot = Quaternion.FromToRotation (NR, LR);
		//}
		//transform.Translate (new Vector3(Input.GetAxis ("Horizontal")*maxSpeed * Time.deltaTime,0, 0) );
	}

}

