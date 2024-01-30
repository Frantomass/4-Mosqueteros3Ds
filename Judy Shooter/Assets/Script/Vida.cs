using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image circleBar;
    public Image extraBar;
    public Image retrato;
    public List<Sprite> lista;


    public float currentVida = 0;
    public float maxVida = 100;

    public float cambioPorcentaje = 0.2f;

    public float circlePorcentaje = 0.5f;

    private void Update()
    {
        CircleFill();
        BarFill();
        actualizarImagen();
    }
    void CircleFill()
    {
        float healthPorcentaje = currentVida / maxVida;
        float circleFill = healthPorcentaje / circlePorcentaje;

        circleFill = Mathf.Clamp(circleFill, 0, 1);
        circleBar.fillAmount = circleFill;
    }
    void BarFill()
    {
        float circleAmounth = circlePorcentaje * maxVida;
        float extraHealth = currentVida - circleAmounth;
        float extraTotalHealth = maxVida - circleAmounth;


        float extraFill = extraHealth / extraTotalHealth;
        extraFill = Mathf.Clamp(extraFill, 0, 1);
        extraBar.fillAmount = extraFill;
    }
    void actualizarImagen()
    {
        if (currentVida/100 <= cambioPorcentaje)
        {
            retrato.sprite = lista[1];
        }
        else
        {
            retrato.sprite = lista[0];
        }

    }
}   
