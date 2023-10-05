using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float movX;
    public float movY;
    bool quieto;
    float tiempo = 2;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector2 direccion = new Vector2(movX, movY);
        rb.velocity = direccion * 3;
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            if (quieto)
            {
                rb.velocity = new Vector2(0f, 0f);
            }

            // cuando pasen los segundos...
            if (tiempo > 0)
            {
                tiempo = tiempo - Time.deltaTime;
            }
            else
            {
                movX = Input.GetAxis("Horizontal");
                movY = Input.GetAxis("Vertical");
                Vector2 direccion = new Vector2(movX, movY);
                rb.velocity = direccion * 3;
            } 
            if (tiempo > 0)
            {
                  tiempo = tiempo - Time.deltaTime;
            }
            else
            {
                quieto = false;
            }
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

