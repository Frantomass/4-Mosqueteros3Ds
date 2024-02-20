using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Animator anim1;
    public float rate = 0.4f;
    bool flip = false;
    bool recarga = false;
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
        anim1 = GetComponent<Animator>();


    }


    void Update()
    {
        if (anim1 != null)
        {

            if (Input.GetMouseButtonDown(0))
            {
                anim1.SetBool("Attack", true);
                Invoke("espera", rate);
            }
            if (Input.GetKeyDown(KeyCode.F) && !flip)
            {
                flip = true;
                anim1.SetBool("Flip", true);
                Invoke("espera2", 1.8f);
            }
            if (Input.GetKeyDown(KeyCode.R) && !recarga)
            {
                flip = true;
                anim1.SetBool("Recargar", true);
                Invoke("espera3", 0.8f);
            }
        }


    }

    public void espera()
    {
        anim1.SetBool("Attack", false);

    }
    public void espera2()
    {
        anim1.SetBool("Flip", false);
        flip = false;

    }
    public void espera3()
    {
        anim1.SetBool("Recargar", false);
        flip = false;

    }

    private AudioSource audioSource;




}
