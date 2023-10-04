using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
    public TMP_Text textoContador;
    float Tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        textoContador.text = "Temporizador";
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo = Tiempo + Time.deltaTime;
        textoContador.text = Tiempo.ToString();
    }
}

        
