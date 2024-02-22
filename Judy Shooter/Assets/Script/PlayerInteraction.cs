using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    
    private GameManager gameManager;

    private void Start()
    {

        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Caja de municion"))
        {
            gameManager.addammo();
            //GameManager.Instance.Cajademunicion = other.gameObject.GetComponent<Cajademunicion>().ammo;
            Destroy(other.gameObject);


        }

    }


}
