using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_CPU : MonoBehaviour
{
    public DisparoCPU disparoCPU;
    public bool stop = false;

    public Transform player;
    Vector3 direction;


    float rotSpeed = 5f;
    float chaseSpeed = 1f;

    float tiempoDisparo = 2f;
    float proximoDisparo;

    public bool numSonidoF1;
    public bool numSonidoF2;
    public bool numSonidoF3;

    void Start()
    {
        numSonidoF1 = true;
        numSonidoF2 = true;
        numSonidoF3 = true;
    }


    void Update()
    {
        if(stop)
        {
            return;

        }

        Cazar();
        FantasmaSonido();
        if (Vector3.Distance(player.position, this.transform.position) < 3)
        {
            Invoke("Disparar", 1f);
        }
        
    }

    void Cazar()
    {
        direction = player.position - this.transform.position;

        if (Vector3.Distance(player.position, this.transform.position) < 100)
        {
            this.transform.rotation =
                Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);

            if (Vector3.Distance(player.position, this.transform.position) > 1.5)
            {
                this.transform.Translate(0, 0, chaseSpeed * Time.deltaTime);
            }
        }
    }

    void Disparar()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            disparoCPU.Disparo();
        }
    }

    void FantasmaSonido()
    {
        if (Vector3.Distance(player.position, this.transform.position) < 10 && numSonidoF1 == true)
        {
            FindAnyObjectByType<AudioManager>().Play("Fantasma");
            numSonidoF1 = false;



        }

        if (Vector3.Distance(player.position, this.transform.position) > 7 && numSonidoF2 == true)
        {
            FindAnyObjectByType<AudioManager>().Play("Fantasma2");
            numSonidoF2 = false;


        }

        if (Vector3.Distance(player.position, this.transform.position) < 3 && numSonidoF3 == true)
        {
            FindAnyObjectByType<AudioManager>().Play("Fantasma3");
            numSonidoF3 = false;

        }
    }

    



}
  





