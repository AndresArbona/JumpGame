using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void EscenaJuego()
    {

        SceneManager.LoadScene("Level");
        Time.timeScale = 1f;
    }
    public void EscenaOpciones()
    {

        SceneManager.LoadScene("Opciones");

    }
    public void SalirJuego()
    {
        Debug.Log("Salir.....");
        Application.Quit();

    }
}
