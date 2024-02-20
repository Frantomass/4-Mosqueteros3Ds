using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJudy : MonoBehaviour
{
    public int cantidadDeDaño = 10;
    private Vida vida;
    private bool cooldown = false;
    private void Start()
    {
        vida = GameObject.FindAnyObjectByType<Vida>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&& !cooldown)
        {
            cooldown = true;
            vida.daño(cantidadDeDaño);
            Invoke("delay", 1);
        }
    } 

    public void delay()
    {
        cooldown = false;
    }
}
