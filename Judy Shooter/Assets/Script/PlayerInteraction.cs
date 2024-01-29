using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Caja de municion"))
        {
            GameManager.Instance.Cajademunicion += other.gameObject.GetComponent<Cajademunicion>().ammo;


      
        }

    }


}
