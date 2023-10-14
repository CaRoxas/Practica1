using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
  public GameObject PanelGameOver;
  public TMP_Text textoContador;
  float Tiempo = 90f;
  public AudioSource Musica;
  public AudioSource Derrota;
  // Start is called before the first frame update
  void Start()
  {
      textoContador.text = "Tiempo";
      Musica = GameObject.Find("Musica").GetComponent<AudioSource>();
      Derrota = GameObject.Find("Derrota").GetComponent<AudioSource>();
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
        PanelGameOver.SetActive(true);
        Musica.Stop();
        Derrota.Play();
      }   
  }
}

        
