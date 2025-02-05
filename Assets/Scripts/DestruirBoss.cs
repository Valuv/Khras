using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBoss : MonoBehaviour
{
    public MeshRenderer bossMesh1, bossMesh2;

    
    public int numAciertos = 20;
    int cuentaAciertos;

    public Animator anim;
    public bool noAbrir = true;

    public IA_Boss1 IA_Boss;

    public GameObject explosion;

    public GameObject ganaste;


    void Start()
    {
        bossMesh1.enabled = true;
        bossMesh2.enabled = true;

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

                bossMesh1.enabled = false;
                bossMesh2.enabled = false;
                IA_Boss.stop = true;
                ganaste.SetActive(true);
                if (noAbrir)
                {
                    anim.Play("AbrirPrimerPiso");
                    noAbrir = false;
                }

            }

        }

        if (collision.gameObject.tag == "BolaPowerUP")
        {

            Instantiate(explosion, this.transform.position, this.transform.rotation);

            //FindAnyObjectByType<AudioManager>().Play("Explotion 1");





            cuentaAciertos += 3;
            Debug.Log(cuentaAciertos);


            if (cuentaAciertos >= 10)
            {

                bossMesh1.enabled = false;
                bossMesh2.enabled = false;
                IA_Boss.stop = true;
                ganaste.SetActive(true);
                if (noAbrir)
                {
                    anim.Play("AbrirPrimerPiso");
                    noAbrir = false;
                }

            }

        }

    }
}
