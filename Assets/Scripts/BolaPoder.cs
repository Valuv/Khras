using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaPoder : MonoBehaviour
{
    public float velMovimiento;

    

    private void Update()
    {
        transform.Translate(Vector3.forward * velMovimiento * Time.deltaTime);
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if ((collision.gameObject.tag == "Ghost"))
        {
            Destroy(gameObject);
            Debug.Log("Destruye");
        }

        
    }



    
}

