using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public static GameManager Instance { get; private set; }


    public int Cajademunicion = 6;

    private void Awake()
    {
        Instance = this;
    }




}
