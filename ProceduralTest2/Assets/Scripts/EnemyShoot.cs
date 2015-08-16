using UnityEngine;
using System.Collections;




public class EnemyShoot : MonoBehaviour {
    [HideInInspector]
    public GameObject[] bulletPrefab;
    public GameObject bullet0;
    public GameObject bullet1;
    public GameObject bullet2;

    private Rigidbody2D Boom;

    [SerializeField]
    private int bulletSpeed =3;
   
    //Later Create Case to Deal with each enemy 


	// Use this for initialization
	void Start () {
	
        Boom = GetComponent<Rigidbody2D>();
        bullet0.GetComponent<Rigidbody2D>();
        bullet1.GetComponent<Rigidbody2D>();
        bullet2.GetComponent<Rigidbody2D>();




	}
	
	// Update is called once per frame
	void Update () {


	
	}



    void Shotgun()
    {
       // GameObject Bullet1 = Instantiate( )
       
        this.Boom.velocity = new Vector2 (bulletSpeed, 0);
        
       /* float Distenemyplayer = Vector3.Distance(playerPOS, this.transform.position);
        
        if (Distenemyplayer < 5)
        {
            bullet0 = Instantiate (bulletPrefaber[0],this.transform.position, Quaternion.identity)as GameObject;
            bullet1 = Instantiate (bulletPrefaber[0],this.transform.position, Quaternion.identity)as GameObject;
            bullet2 = Instantiate (bulletPrefaber[0],this.transform.position, Quaternion.identity)as GameObject;
            
            
            
            
        }
*/




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