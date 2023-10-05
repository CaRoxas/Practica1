using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
    public TMP_Text textoContador;
    float Tiempo = 120f;
    bool Temporizador = true;
    // Start is called before the first frame update
    void Start()
    {
        textoContador.text = "Tiempo";
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo > 0)
        {
          Tiempo = Tiempo - Time.deltaTime;
          textoContador.text = Tiempo.ToString();
        }
        else
        {
          Tiempo = 0;
          Temporizador = false;
        }
    }
}

        
