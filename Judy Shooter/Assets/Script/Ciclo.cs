using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ciclo : MonoBehaviour
{
    [Range(0.0f, 24f)] public float Hora = 12;
    public Transform Sol;

    private float SolX;

    public float DuracionDelDiaEnMinutos = 5;

    private void Update()
    {
        Hora += Time.deltaTime * (24 / (60 * DuracionDelDiaEnMinutos));
        RotacionSol();

        if (Hora >= 24 ) 
        {
            Hora = 0;
        }
    }


    void RotacionSol()
    {
        SolX = 15 * Hora;

        Sol.localEulerAngles = new Vector3(SolX, 0, 0);

        if (Hora < 6 || Hora > 18)
        {
            Sol.GetComponent<Light>().intensity = 0;
        }
        else
        {
            {
                Sol.GetComponent<Light>().intensity = 1;
            }
        }
    }

}
