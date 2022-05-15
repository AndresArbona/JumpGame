using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuOpciones : MonoBehaviour
{
    [SerializeField] Slider Volumen;

    // Start is called before the first frame update
    public void Volver()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void CambioVolumen()
    {

        AudioListener.volume = Volumen.value;

    }
}

