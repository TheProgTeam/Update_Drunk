using UnityEngine;
using System.Collections;
namespace Scripts
{
public class checkfortrigger : MonoBehaviour {


	
	
		void OnCollisionEnter2D()

		{
			Debug.Log ("Hah! Chris");

		}

	
	void OnTriggerEnter2D()
		{
	
	
			Debug.Log ("trigger!!!");

		}
	
}
}