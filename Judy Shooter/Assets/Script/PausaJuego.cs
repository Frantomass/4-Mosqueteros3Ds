using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaJuego : MonoBehaviour
{
    public GameObject menuPausa;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
