using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteJudy : MonoBehaviour
{
    public int vida = 100; // O cualquier valor inicial de vida que estés utilizando.

    // Llamado cuando el jugador pierde vida
    public void PerderVida()
    {
        vida--;

        if (vida <= 0)
        {
            // Cargar la nueva escena cuando la vida llega a cero
            SceneManager.LoadScene("NombreDeTuNuevaEscena");
        }
    }
}
