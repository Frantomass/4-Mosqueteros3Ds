using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI ammoText;


    public static GameManager Instance { get; private set; }


    public int Cajademunicion = 6;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        ammoText.text = Cajademunicion.ToString(); 
    }




}
