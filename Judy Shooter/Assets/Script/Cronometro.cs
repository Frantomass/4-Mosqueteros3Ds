using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cronometro : MonoBehaviour
{
    public Text tiempoText;
    private float tiempoTranscurrido;
    private bool cronometroActivo = false;

    void Update()
    {
        if (cronometroActivo)
        {
            tiempoTranscurrido += Time.deltaTime;
            ActualizarTextoCronometro();
        }
    }

    void ActualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60);
        int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60);
        int milisegundos = Mathf.FloorToInt((tiempoTranscurrido * 1000) % 1000);

        tiempoText.text = string.Format("{0:00}:{1:00}:{2:000}", minutos, segundos, milisegundos);
    }

    public void IniciarCronometro()
    {
        tiempoTranscurrido = 0f;
        cronometroActivo = true;
    }

    public void DetenerCronometro()
    {
        cronometroActivo = false;
    }

    public void ReiniciarCronometro()
    {
        tiempoTranscurrido = 0f;
        ActualizarTextoCronometro();
    }
}