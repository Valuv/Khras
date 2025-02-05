using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuemarPuerta : MonoBehaviour
{
    public GameObject puerta;
    

    public GameObject explosion;

    private void OnTriggerEnter(Collider collision)
    {

        if ((collision.gameObject.tag == "BolaPoder"))
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            puerta.SetActive(false);
           

        }


    }
}
