using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public int velocidad = 3;
    bool derecha = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Examen
        if (transform.position.x > -2)
        {
            derecha = false;
        }
        else if (transform.position.x < -7) 
        {
            derecha = true;
        }
        if (derecha == true)
        {
            transform.Translate(velocidad * Vector2.right * Time.deltaTime);
        }
        else
        {
            transform.Translate(velocidad * Vector2.left * Time.deltaTime);
        }
    }
}
