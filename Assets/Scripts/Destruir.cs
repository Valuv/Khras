using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

public class Destruir : MonoBehaviour
{
    public ContinuousMoveProvider cmp;
    public IA_CPU iA_Cpu;
    public Menu pausa;
    

    public int numAciertos = 10;
    public int cuentaAciertos;

    public GameObject perdisteCanva;

    public Health_Bar health;
    
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "BolaPoderCPU")
        {
            Debug.Log("impacto");
            ContactPoint contact = collision.contacts[0];
            Vector3 pos = contact.point;
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Instantiate(explosion, pos, rot);

            //FindAnyObjectByType<AudioManager>().Play("Explotion 1");

            Instantiate(explosion, this.transform.position, this.transform.rotation);//

            //Instantiate(explosion, transform.position, transform.rotation);


            cuentaAciertos++;
            health.BajarVida(); 


            if (cuentaAciertos != 0 && cuentaAciertos % numAciertos == 0)
            {
                GameOverMenu();
                cmp.moveSpeed = 0;  
                
            }

        }

        if (collision.gameObject.tag == "BolaBoss")
        {
            Debug.Log("impacto");
            ContactPoint contact = collision.contacts[0];
            Vector3 pos = contact.point;
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Instantiate(explosion, pos, rot);

            //FindAnyObjectByType<AudioManager>().Play("Explotion 1");

            Instantiate(explosion, this.transform.position, this.transform.rotation);

            //Instantiate(explosion, transform.position, transform.rotation);


            cuentaAciertos += 2;



            if (cuentaAciertos != 0 && cuentaAciertos % numAciertos == 0)
            {
                GameOverMenu();

            }

        }

    }

    void GameOverMenu()
    {
        perdisteCanva.SetActive(true);
        iA_Cpu.stop = true;
        Time.timeScale = 0;

    }

}
