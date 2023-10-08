using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Puntuaje : MonoBehaviour
{
    public TMP_Text textoMonedas;
    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            puntos = puntos + 1;
            textoMonedas.text = "Monedas " + puntos;
        }
    }
}
