using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBullet : MonoBehaviour

{
    public AudioSource controlSonido;
    public AudioClip SonidoDisparo;
    void Start()
    {
        controlSonido = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            controlSonido.PlayOneShot(SonidoDisparo);
            
        }
    }
}

