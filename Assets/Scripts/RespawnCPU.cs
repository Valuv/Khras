using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCPU : MonoBehaviour
{
    public IA_CPU iA_Cpu;

    public Puntaje puntaje;

    public GameObject explosion;
    public GameObject tanqueCPU;
    public GameObject refMap;

    Vector3 map;

    void Update()
    {
        
    }

    void RespawnEnemies()
    {
        map = new Vector3(refMap.transform.position.x, refMap.transform.position.y, refMap.transform.position.z);

        float offsetX = Random.Range(-15f, 15f);
        float offsetZ = Random.Range(-15f, 15f);

        Vector3 nuevaPosicion = new Vector3(map.x + offsetX, 10, map.z + offsetZ);

        GameObject enemy = Instantiate(tanqueCPU, nuevaPosicion, Quaternion.identity);
        
    }

}
