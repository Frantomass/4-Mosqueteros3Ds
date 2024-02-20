using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBullet : MonoBehaviour

{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            audioSource.Play();
            
        }
    }
}

