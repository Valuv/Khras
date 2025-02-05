using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCPU : MonoBehaviour
{
    public GameObject bolaPoder;

    public void Disparo()
    {
        Instantiate(bolaPoder, transform.position, transform.rotation);
    }
}
