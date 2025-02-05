using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMovimiento : MonoBehaviour
{
    float rot, tras;
    public float velRot, velTras;
    public bool pausa;
    private void Update()
    {
        if (!pausa)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                Rotacion();
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                Traslacion();
                //FindAnyObjectByType<AudioManager>().Play("Motor");
            }
        }



    }


    void Rotacion()
    {
        rot = Input.GetAxis("Horizontal") * velRot * Time.deltaTime;
        transform.Rotate(0, rot, 0);
    }

    void Traslacion()
    {
        tras = Input.GetAxis("Vertical") * velTras * Time.deltaTime;
        transform.Translate(0, 0, tras);
    }

}
