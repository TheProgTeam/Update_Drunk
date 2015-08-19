using UnityEngine;
using System.Collections;


namespace Scripts
{

public class PlayerShooting : MonoBehaviour {

        public GameObject[] bulletPrefab1;
        


	//private Rigidbody2D Bu2D;
        public Vector3 Current_pos;
        public Vector3 dir;
       private GameObject bulletMade;
        private float bulleOffset;
        private bool P = true;
        private bool S = false;

	
	
	

        //Use this for initiBoom = GetComponent<Rigidbody2D> ();

	void Start () 
	{
           // Boom = GetComponent<Rigidbody2D>();
           
           

           
       
	}




	//When player pushes left click, instantiate a bullet object. make it travel in the direction of the mouse click
	//If bullet hits either object tagged with wall or enemy destroy bullet object

	void Update() 
        {

            if(Input.GetKey("1") )
            {
                P= true;
                S= false;



            }
            if(Input.GetKey("2"))
            {

                S= true;
                P = false;


            }
           

            Current_pos = Camera.main.WorldToScreenPoint(transform.position);

            if (P)

            {
            if (Input.GetButtonDown("Fire1"))
            {
                    
                //GameObject toInstantiate2 = bulletPrefab1[0];

               
               StraightShooting();
                

                //Pl2D.AddForce (Dir*200);
            }

            }

            if(S)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    
                    //GameObject toInstantiate2 = bulletPrefab1[0];
                    
                    
                    SpreadShooting();
                    
                    
                    //Pl2D.AddForce (Dir*200);
                }



            }
           

			
		}


 public void StraightShooting()
        {   
            MakeBullet();
            Vector3 Starting_Pos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = (Input.mousePosition - Starting_Pos).normalized;
            //Vector3 DirectionAngle = new Vector3 (Mathf.Cos(30),Mathf.Sin(30),0);
            bulletMade.GetComponent<Rigidbody2D>().AddForce(dir*500);
           
           

        }

public void SpreadShooting()
        {
            MakeBullet();
            Vector3 Starting_Pos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = (Input.mousePosition - Starting_Pos).normalized;
           
            bulletMade.GetComponent<Rigidbody2D>().AddForce(dir*500);

            MakeBullet();
            Vector3 DirectionAngle = new Vector3 ( (dir.x+Mathf.Cos(5)), dir.y+Mathf.Sin(5)).normalized;
            bulletMade.GetComponent<Rigidbody2D>().AddForce(500*DirectionAngle);
           MakeBullet();
            Vector3 DirectionAngle1 = new Vector3 (Mathf.Cos(-5)+dir.x, dir.y+Mathf.Sin(-5),0).normalized;
            bulletMade.GetComponent<Rigidbody2D>().AddForce(DirectionAngle1*500);



        }

 public void MakeBullet()
        {

           
           bulletMade = Instantiate (bulletPrefab1[0],this.gameObject.transform.position, Quaternion.identity) as GameObject;


        
           

        }

	//Get Bullet path from Player script "Fire1" Button
	public void Trajectory()
	{
		/*if (Physics.Raycast (ray))
			Instantiate (Projectile, ray.direction, Quaternion.identity);
		Debug.Log (Projectile.transform.localPosition);


		*/



	}

	


    }

}
