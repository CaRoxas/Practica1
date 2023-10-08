using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Jugador : MonoBehaviour
{
    public TMP_Text textoMonedas;
    public float movX;
    public float movY;
    bool quieto;
    float tiempo = 2f;
    public int puntos;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (quieto == false) 
        {
            movX = Input.GetAxis("Horizontal");
            movY = Input.GetAxis("Vertical");
            Vector2 direccion = new Vector2(movX, movY);
            rb.velocity = direccion * 3;
        }
        else
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - Time.deltaTime;
                quieto = true;
            }
            else
            {
                tiempo = 0;
                quieto = false;
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Premio")
        {
            Destroy (gameObject);
            PauseGame();
        }
        if (col.gameObject.tag == "Monedas")
        {
            puntos = puntos + 1;
            textoMonedas.text = "Monedas " + puntos;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            quieto = true;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}

