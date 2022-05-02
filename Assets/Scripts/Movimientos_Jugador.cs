using UnityEngine;

public class Movimientos_Jugador : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Cuerpo;
    [SerializeField] private float Velocidad;

    private void Awake()
    {
        Cuerpo = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Cuerpo.velocity = new Vector2(Input.GetAxis("Horizontal") * Velocidad, Cuerpo.velocity.y);

        if (Input.GetKey(KeyCode.Space))
            Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, Velocidad);
    }
}
