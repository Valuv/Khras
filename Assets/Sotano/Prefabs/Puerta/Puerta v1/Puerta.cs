using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    private Animator animator;
    public GameObject puerta; 

    private void Start()
    {
        animator = puerta.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Llave")){
            animator.SetTrigger("Abrir");
            Debug.Log("entro");
        }
    }

}
