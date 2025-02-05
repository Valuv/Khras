using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCPU : MonoBehaviour
{
    public IA_CPU iA_Cpu;
    public int numAciertos = 10;
    int cuentaAciertos;
    

    public Puntaje puntaje;

    public GameObject explosion;
    public GameObject refMap;
    

    public MeshRenderer objeto1, objeto2;

    Vector3 map;

    void Start()
    {
        objeto1.enabled = true;
        objeto2.enabled = true;
        
    }


    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "BolaPoder")
        {
            
            Instantiate(explosion, this.transform.position, this.transform.rotation);

            //FindAnyObjectByType<AudioManager>().Play("Explotion 1");


         


            cuentaAciertos++;
            Debug.Log(cuentaAciertos);


            if (cuentaAciertos != 0 && cuentaAciertos % numAciertos == 0)
            {
                //FindAnyObjectByType<AudioManager>().Play("MuerteFantasma");
                puntaje.sumarMuertes();
                objeto1.enabled = false;
                objeto2.enabled = false;
                iA_Cpu.stop = true;
                iA_Cpu.numSonidoF1 = true;
                iA_Cpu.numSonidoF2 = true;
                iA_Cpu.numSonidoF3 = true;
                ReposEnemies();
                cuentaAciertos = 0; //Probar antes y despues del Invoke 
                Invoke("ReiniciarCaza", 10f);
                

            }

        }

        if (collision.gameObject.tag == "BolaPowerUP")
        {

            Instantiate(explosion, this.transform.position, this.transform.rotation);

            //FindAnyObjectByType<AudioManager>().Play("Explotion 1");





            cuentaAciertos += 3;
            Debug.Log(cuentaAciertos);


            if (cuentaAciertos >= 2)
            {
                //FindAnyObjectByType<AudioManager>().Play("MuerteFantasma");
                puntaje.sumarMuertes();
                objeto1.enabled = false;
                objeto2.enabled = false;
                iA_Cpu.stop = true;
                iA_Cpu.numSonidoF1 = true;
                iA_Cpu.numSonidoF2 = true;
                iA_Cpu.numSonidoF3 = true;
                ReposEnemies();
                cuentaAciertos = 0; //Probar antes y despues del Invoke 
                Invoke("ReiniciarCaza", 10f);


            }

        }

    }

    void ReposEnemies()
    {
        map = new Vector3(refMap.transform.position.x, refMap.transform.position.y, refMap.transform.position.z);

        float offsetX = Random.Range(-15f, 15f);
        float offsetZ = Random.Range(-15f, 15f);

        Vector3 nuevaPosicion = new Vector3(map.x + offsetX, 1.5f, map.z + offsetZ);

        gameObject.transform.position = nuevaPosicion;
        //enemy.GetComponent<IA_CPU>().ReiniciarCaza();
    }

    


    void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    void ReiniciarCaza()
    {
        iA_Cpu.stop = false;
        objeto1.enabled = true;
        objeto2.enabled = true;
       
    }

}