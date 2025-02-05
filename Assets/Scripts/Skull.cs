using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public GameObject skull;
    public GameObject llave;

    public GameObject explosion;

    private void OnTriggerEnter(Collider collision)
    {

        if ((collision.gameObject.tag == "BolaPoder"))
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            skull.SetActive(false);
            llave.SetActive(true);

        }


    }

   
}
