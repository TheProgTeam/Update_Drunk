using UnityEngine;
using System.Collections;

public class BulletDestroyer : MonoBehaviour {

    public void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Destroy(gameObject,0.6f);
            
    }
}
