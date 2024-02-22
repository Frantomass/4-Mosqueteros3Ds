using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaJuego : MonoBehaviour
{
    public GameObject menuPausa;

    void Start()
    {
        // Bloquear el cursor al centro de la pantalla
        Cursor.lockState = CursorLockMode.Locked;
        // Ocultar el cursor
        //Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Desbloquear el cursor
            Cursor.lockState = CursorLockMode.None;
            // Mostrar el cursor
            Cursor.visible = true;
            if (Time.timeScale == 1f)
            {
                PausarJuego();
            }
            else
            {
                ReanudarJuego();
            }
        }
    }

    void PausarJuego()
    {
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Resume()
    {
        ReanudarJuego();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
