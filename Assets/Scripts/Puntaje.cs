using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text scoreTextoMuertes;
    public Text scoreTextoCuraciones;
    public Text scoreTextoPowerUp;
    public int scoreMuertes;
    public int scoreCuraciones;
    public int scorePowerUp;



    private void Start()
    {
        scoreCuraciones = 3;
        scoreTextoCuraciones.text = scoreCuraciones.ToString();
        scoreMuertes = 0;
        scoreTextoMuertes.text = scoreMuertes.ToString();
    }

    public void sumarMuertes()
    {
        scoreMuertes += 1;
        scoreTextoMuertes.text = scoreMuertes.ToString();
    }

    public void restarCuraciones()
    {
        if(scoreCuraciones > 0)
        {
            scoreCuraciones -= 1;
            scoreTextoCuraciones.text = scoreCuraciones.ToString();
        }
        
    }

    public void PowerUpDisponibles()
    {
        if(scorePowerUp < 3)
        {
            scorePowerUp += 1;
            scoreTextoPowerUp.text = scorePowerUp.ToString();
        }
        
    }

    public void PowerUpGastados()
    {
        scorePowerUp -= 1;
        scoreTextoPowerUp.text = scorePowerUp.ToString();
    }






}