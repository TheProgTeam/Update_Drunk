using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public Rigidbody2D Boom;
	// Use this for initialization
	void Start () 
    {
        Boom = GetComponent<Rigidbody2D> ();
        Vector3 Starting_Pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - Starting_Pos).normalized;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
