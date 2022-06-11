using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ira : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Canvas Perdiste; 
    private BoxCollider2D Colision;
    private bool Tocar;

    private void Awake()
    {
        Colision = GetComponent<BoxCollider2D>();
        Tocar = false;
    }

    private void Update()
    {
        Subir();
        if (Tocar == true)
        {
            GameOver();
        }
    }

    private void Subir() { 
       transform.position = new Vector2(transform.position.x, transform.position.y + velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            Tocar = true;
    }
    private void GameOver() 
    {
        Time.timeScale = 0f;
        Perdiste.GetComponent<Transform>().gameObject.SetActive(true);
    }
}
