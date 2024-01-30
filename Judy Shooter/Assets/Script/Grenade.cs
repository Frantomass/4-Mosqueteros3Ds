using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float delay = 3f;
    float coutdown;
    public float radius = 5f;
    public float explosionForce = 70;
    bool exploded = false;
    public GameObject explosionEffect;
    void Start()
    {
        coutdown = delay; 
    }
    void Update()
    {
        coutdown -= Time.deltaTime;  
        
        if (coutdown <=0 && exploded == false)
        {
            Explode();
            exploded = true;
        }
    }

    void Explode()
    {

        GameObject grenade=Instantiate(explosionEffect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);   
        foreach (var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(explosionForce * 10, transform.position,radius);
            }
        }

        Destroy(gameObject);
        Destroy(grenade, 2);
    }
}
