using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaMenu : MonoBehaviour

{
    public GameObject pauseMenu;

    void Start()
    {
        // Desactivar el menú de pausa al inicio del juego
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor al inicio
        Cursor.visible = false; // Hacer el cursor invisible al inicio
    }

    void Update()
    {
        // Verificar si se presiona la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Alternar la visibilidad del menú de pausa
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // Obtener el estado actual del menú de pausa
        bool isPaused = pauseMenu.activeSelf;

        // Invertir el estado (activar/desactivar)
        pauseMenu.SetActive(!isPaused);

        // Pausar o reanudar el juego según el estado del menú de pausa
        Time.timeScale = isPaused ? 1f : 0f;

        // Manejar el cursor según el estado del menú de pausa
        Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isPaused;
    }

}


