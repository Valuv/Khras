using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runas : MonoBehaviour
{
    public GameObject refMap;
    Vector3 map;
    public MeshRenderer runa;

    public GameObject explosion;

    public float tiempoRuna = 15f;
    float proximaRuna;



    void Start()
    {
        runa.enabled = true;
    }


    private void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "Player") && (Time.time > proximaRuna))
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            runa.enabled = false;
            proximaRuna = Time.time + tiempoRuna;
            ReposRunas();
            Invoke("EnableRuna", 15f);
        }


    }



    void ReposRunas()
    {
        map = new Vector3(refMap.transform.position.x, refMap.transform.position.y, refMap.transform.position.z);

        float offsetX = Random.Range(-4f, 4f);
        float offsetZ = Random.Range(-4f, 4f);
        

        Vector3 nuevaPosicion = new Vector3(map.x + offsetX, 3f, map.z + offsetZ);

        gameObject.transform.position = nuevaPosicion;
        

    }

    void EnableRuna()
    {
        runa.enabled = true;
    }
}
