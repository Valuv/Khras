using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject tutorial;

    void Start()
    {
        Invoke("CerrarCanvas", 15f);
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        // Limpiar los PlayerPrefs al iniciar un nuevo juego
        
        SceneManager.LoadScene(1);



    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("salio del jogo");
    }

    public void Intro()
    {
        SceneManager.LoadScene(0);
    }

    public void Pausa()
    {
        Time.timeScale = 0;
    }

    public void Reanudar()
    {
        Time.timeScale = 1;
    }

   

    void CerrarCanvas()
    {
        tutorial.SetActive(false);

    }



}
