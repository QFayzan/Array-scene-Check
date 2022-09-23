using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
   
    public float delay =0.5f;
    public float bombRadius = 1.0f;
    public float explosionForce = 700.0f;
    float countdown;
   // public GameObject explosionEffect;
    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Explosion()
    {
        //Instantiate(explosionEffect, transform.position, transform.rotation);
       Collider[] colliders =  Physics.OverlapSphere(transform.position , bombRadius);
       foreach(Collider nearbyObject in colliders)
       {
       Rigidbody rb =  nearbyObject.GetComponent<Rigidbody>();
       if (rb !=null)
       {
        rb.AddExplosionForce(explosionForce , transform.position , bombRadius);
       }
       Debug.Log("Boom !!");
        Destroy(gameObject);
    }
    }
    void OnCollisionEnter (Collision other)
    {
         if (other.gameObject.tag=="Player")
        Explosion();
    }
    
}
