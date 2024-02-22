using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego 1");
        Cursor.lockState = CursorLockMode.Locked;

    }


    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }

    public void Volver()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
