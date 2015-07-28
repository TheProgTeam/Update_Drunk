using UnityEngine;
using System.Collections;

public class Weapons : MonoBehaviour {







	//public Ray ray;


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 Starting_Pos_wep = Camera.main.WorldToScreenPoint(transform.position);
		Vector3  Wep_dir = (Input.mousePosition - Starting_Pos_wep).normalized;


		/*
			if (Input.GetButtonDown("Fire1")) {
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray))
				Instantiate (Projectile, ray.direction, Quaternion.identity);
			Debug.Log (Projectile.transform.localPosition);
				
			}
*/		
	}
}
