using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if ((collision.gameObject.tag == "Player"))
        {
            SceneManager.LoadScene(0);


        }


    }

   
}
