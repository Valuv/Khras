using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curar : MonoBehaviour
{
    public int healCount;
    public Destruir player;
    public Puntaje puntaje;

    void Start()
    {
        healCount = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown("q") && healCount > 0)
        {
            Heal();
        }
    }

    public void Heal()
    {
        

        if (healCount > 0)
        {
            healCount--;
            player.cuentaAciertos -= 2;
            puntaje.restarCuraciones();
        }


    }

}
