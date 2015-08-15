using UnityEngine;
using System.Collections;




public class EnemyShoot : MonoBehaviour {

    public GameObject[] bulletPrefab;

    private Rigidbody2D Boom;

    [SerializeField]
    private int bulletSpeed =3;
   
    //Later Create Case to Deal with each enemy 


	// Use this for initialization
	void Start () {
	
        Boom = GetComponent<Rigidbody2D>();




	}
	
	// Update is called once per frame
	void Update () {


	
	}



    void Shotgun()
    {
        GameObject Bullet1 = Instantiate( )
       
        this.Boom.velocity = new Vector2 (bulletSpeed, 0);





    }


    /*
            Boom = GetComponent<Rigidbody2D> ();
            Vector3 Starting_Pos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 Dir = (Input.mousePosition - Starting_Pos).normalized;
            Boom.AddForce (Dir*500);

     */



void OnCollisionEnter2D()
{
    
    
    Destroy (gameObject);
    
    
    
    
}

void OnTriggerEnter2D()
{
    
    
    Destroy (gameObject);
    
    
    
    
}


}