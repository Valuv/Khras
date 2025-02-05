using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaPowerUP : MonoBehaviour
{
    public GameObject bolaPowerUP;
    public float tiempoDisparo = 1f;
    float proximoDisparo;
    public PowerUp numRunas;
    public Puntaje puntaje;
    public PowerUp runas; 

    public void DispararPowerUp()
    {
        if (Time.time > proximoDisparo && runas.runasCount > 0)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            Instantiate(bolaPowerUP, transform.position, transform.rotation);
            numRunas.runasCount--;
            puntaje.PowerUpGastados();
        }

    }
}
