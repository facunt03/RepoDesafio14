using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Cronometro : MonoBehaviour
{
    public Text UICronometro;
    private int contador = 0;

    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 1f);
    }


    void Update()
    {
        
    }
    private void Cronometro() 
    {
        contador++;
        UICronometro.text = contador.ToString();
    }
}
