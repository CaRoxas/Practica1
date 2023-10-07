using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Monedas : MonoBehaviour
{
    public TMP_Text textoMonedas;
    Rigidbody rb;
    private int monedas = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        textoMonedas.text = monedas.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            monedas = monedas + 1;

        }
    }
}
