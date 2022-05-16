using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tristeza : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private BoxCollider2D Colision;
    private bool Tocar;
    private bool Muerte;

    private void Awake()
    {
        Colision = GetComponent<BoxCollider2D>();
        Tocar = false;
        Muerte = false;
    }

    private void Update()
    {
        Subir();
        if (Tocar == true)
        {
            GameOver();
            Tocar = false;
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
        Debug.Log("muerte");
        Muerte = true;
    }
}
