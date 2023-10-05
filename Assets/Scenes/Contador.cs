using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
    public TMP_Text textoContador;
    float Tiempo = 0f;
    //bool Contador = false
    // Start is called before the first frame update
    void Start()
    {
        textoContador.text = "Temporizador";
        //Contador = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*/if (Contador)
        {
            if (timeRemaining > 0)
            {
            timeRemaining -= Time.deltaTime;
            }
        }
        else
        {
            timeRemaining = 0;
            Contador = false;
        }*/
        
        
        
        
        Tiempo = Tiempo + Time.deltaTime;
        /*/textoContador.text = Tiempo.ToString();
        for (int i = 2; i > Tiempo; i--)*/
        {

        } 
        
    }
}

        
