using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    // Referencia al componente RawImage
    public RawImage rawImage;

    // Variable pública para almacenar la altura deseada
    //public int nuevaAltura = 10;

    public int ancho, alto = 100;
    public Destruir destruir;
    public Curar curar;


    void Start()
    {
        rawImage.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho, alto);
    }

    void Update()
    {
      if(curar.healCount > 0)
        {
            alto = (10 - destruir.cuentaAciertos) * 10;
            rawImage.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho, alto);
        }
    }

    public void BajarVida()
    {
        alto = (10 - destruir.cuentaAciertos) * 10;
        rawImage.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho, alto);
    }

    public void Morir()
    {
        alto = (10 - destruir.cuentaAciertos) * 10;
        rawImage.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho, alto);
    }


}
