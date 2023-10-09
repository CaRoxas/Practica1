using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    Rigidbody rb;
    public AudioSource FXMonedas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FXMonedas = GameObject.Find("FXMoneda").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            FXMonedas.Play();
        }
    }
}
