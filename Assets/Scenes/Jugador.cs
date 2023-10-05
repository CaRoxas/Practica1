using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float movX;
    public float movY;
    public float tiempo;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        Debug.Log(tiempo);
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector2 direccion = new Vector2(movX, movY);
        rb.velocity = direccion * 3;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            PauseGame();
        }
    }
    /*/private void OnCollisionExit2D(Collision2D collision)
    {
        if (tiempo = tiempo + Time.deltaTime + 2)
        {
            ResumeGame();
        }

    }*/

    void PauseGame ()
    {
        Time.timeScale = 0;
    }
    void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}
