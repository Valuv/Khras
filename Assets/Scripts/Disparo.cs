using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bolaPoder;
    public float tiempoDisparo = .5f;
    float proximoDisparo;

    private void Update()
    {
        if (Input.GetKey("space") && Time.time > proximoDisparo)
        {
            Disparar();
        }
    }

    public void Disparar()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            Instantiate(bolaPoder, transform.position, transform.rotation);
        }
        
    }
}
