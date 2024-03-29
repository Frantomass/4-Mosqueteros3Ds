using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float shotForce = 1500f;
    public float shotRate = 0.5f; 
    private float shotRateTime = 0;
    public GameObject BulletExplosions;
 




    void Update()
    {
         if (Input.GetButtonDown("Fire1"))

            if(Time.time > shotRateTime && GameManager.Instance.Cajademunicion > 0)
            {
               GameManager.Instance.Cajademunicion--;

               GameObject bulletexplosion= Instantiate(BulletExplosions, spawnPoint, BulletExplosions.transform);

               GameObject newBullet;

               newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
               newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

               shotRateTime = Time.time + shotRate;

               Destroy(newBullet,10);
               Destroy(bulletexplosion, 1);
            }
          

    }
}

