using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Menu_Pausa;
    public static bool EnPausa;

    void Awake()
    {
        Menu_Pausa.SetActive(false);
    }
    void Update()
    {
        if (!EnPausa && Input.GetKey(KeyCode.Escape))
        {
            if (EnPausa)
                ResumenJuego();
            else
                PausaJuego();
        }
    }

    public void PausaJuego()
    {
        EnPausa = true;
        Menu_Pausa.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumenJuego()
    {
        EnPausa = false;
        Menu_Pausa.SetActive(false);
        Time.timeScale = 1f;
    }
    public void EscenaOpciones()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("OpcionesJuego");
    }
    public void VolverAlMenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }
}
