using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaBoss : MonoBehaviour
{
    public float velMovimiento;

    private void Update()
    {
        transform.Translate(Vector3.forward * velMovimiento * Time.deltaTime);
        Destroy(gameObject, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
