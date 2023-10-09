using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Jugador : MonoBehaviour
{
    public TMP_Text textoMonedas;
    public GameObject PanelInutil;
    public GameObject PanelMedio;
    public GameObject PanelCrack;
    public float movX;
    public float movY;
    public bool quieto;
    float tiempo = 2f;
    public int puntos;
    Rigidbody2D rb;
    public GameObject Movible;
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Paredes")
        {
            quieto = true;
            tiempo = 2f;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        //Examen
        if (collision.gameObject.tag == "Cambiador")
        {
            transform.localScale = new Vector2(0.3f, 0.5f);
        }
        if (collision.gameObject.tag == "Llave")
        {
            Destroy(Movible);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Premio")
        {
            Destroy (gameObject);
            PauseGame();
            if (puntos == 6)
            {
                Debug.Log("SuperMensaje");
            }
            else if (puntos < 6 && puntos > 0)
            {
                Debug.Log("Mensaje Medio");
            }
            else
            {
                Debug.Log("Matado");
            }
        }
        if (col.gameObject.tag == "Monedas")
        {
            puntos = puntos + 1;
            textoMonedas.text = "Rupias " + puntos;
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

