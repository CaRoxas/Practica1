using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    Rigidbody rb;
    public Puntuaje scriptpuntos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy (col.gameObject);
            PauseGame();
            
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
