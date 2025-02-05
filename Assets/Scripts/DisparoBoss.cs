using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBoss : MonoBehaviour
{
    public GameObject bolaPoderBoss;

    public void Disparo()
    {
        Instantiate(bolaPoderBoss, transform.position, transform.rotation);
    }
}
