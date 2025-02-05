using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public int runasCount;
    
    public DisparaPowerUP disparo;
    public Puntaje puntaje;

    void Start()
    {
        runasCount = 0;
    }

    
    void Update()
    {

        if (Input.GetKeyDown("p") && runasCount > 0)
        {
            disparo.DispararPowerUp();
            Debug.Log(runasCount);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "Runa") && runasCount < 3)
        {
            runasCount++;
            Debug.Log("Runa");
            Debug.Log("Runas Count es " + runasCount);
            puntaje.PowerUpDisponibles();
        }
    }

}
