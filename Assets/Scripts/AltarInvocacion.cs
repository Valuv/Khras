using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarInvocacion : MonoBehaviour
{
    public GameObject foto;
    public GameObject estatua;
    public int contador = 0;

    public Puntaje contadorAlmas;
    public GameObject jefe;
    public GameObject fantasma;


    

    private void OnTriggerEnter(Collider other)
    {
        //Aparecer y destruir la estatua en el altar, el objeto debe tener el tag "Foto"
        if (other.CompareTag("Foto"))
        {
            Debug.Log("entro");
            Destroy(other.gameObject);
            foto.SetActive(true);
            contador++;
        }


        //Aparecer y destruir la estatua en el altar, el objeto debe tener el tag "Estatua"
        if (other.CompareTag("Estatua"))
        {
            Destroy(other.gameObject);
            estatua.SetActive(true);
            contador++;
        }


        //Invocacion jefe
        if (contadorAlmas.scoreMuertes >= 2 && contador >= 2)
        {
            jefe.SetActive(true);
            fantasma.SetActive(false);
        }
    }
}
