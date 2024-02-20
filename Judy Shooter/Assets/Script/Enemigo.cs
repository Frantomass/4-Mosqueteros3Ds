using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 5f;
    private GameManager gamemanager;

    private int disparosRecibidos = 0;
    public int disparosMaximos = 15;
    public bool attack = false;


    private void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    void Update()
    {
        if (!attack)
        {
            Target();
        }
        else
        {
            Invoke("cooldown", 1);
        }
    }

    // Función para recibir un disparo
    public void RecibirDisparo()
    {
        disparosRecibidos++;

        // Verificar si se han recibido suficientes disparos para destruir al enemigo
        if (disparosRecibidos >= disparosMaximos)
        {
            // Destruir el enemigo
            Debug.Log("AY");
            gamemanager.matamata();
            //gameObject.SetActive(false);
            //Destroy(gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Area"))
        {
            attack = true;


        }
    }

    public void cooldown()
    {
        attack = false;
    }

    public void Target()
    {
        if (objetivo != null)
        {

            Vector3 direccion = (objetivo.position - transform.position).normalized;


            Vector3 movimiento = direccion * velocidad * Time.deltaTime;
            transform.Translate(movimiento);

            transform.LookAt(objetivo);
        }
    }


}
