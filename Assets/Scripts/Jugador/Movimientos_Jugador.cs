using UnityEngine;

public class Movimientos_Jugador : MonoBehaviour
{
    [Header ("Variables de movilidad")]

    [SerializeField] private float VelocidadMovimiento;
    [SerializeField] private float MaxSalto;

    [Header("Layers")]
    [SerializeField] private LayerMask SuperficieLayer;

    private BoxCollider2D Colision;
    private Rigidbody2D Cuerpo;

    private float MovimientosJugador;
    private bool PuedeSaltar = true;
    private float ValorSalto = 0.0f;
    private float TiempoX;
    private float TiempoY;

    private void Awake()
    {
        Cuerpo = GetComponent<Rigidbody2D>();
        Colision = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        MovimientosJugador = Input.GetAxis("Horizontal");

        if (ValorSalto == 0.0f && EnSuelo())
        Cuerpo.velocity = new Vector2(MovimientosJugador * VelocidadMovimiento, Cuerpo.velocity.y);

        if (Input.GetKey(KeyCode.Space) && EnSuelo() && PuedeSaltar)
            ValorSalto += 0.1f;

        if (Input.GetKeyDown(KeyCode.Space) && EnSuelo() && PuedeSaltar)
        {
            Cuerpo.velocity = new Vector2(0.0f, Cuerpo.velocity.y);
        }

        if (ValorSalto >= MaxSalto && EnSuelo())
        {
            TiempoX = MovimientosJugador * VelocidadMovimiento;
            TiempoY = ValorSalto;
            Cuerpo.velocity = new Vector2(TiempoX, TiempoY);
            Invoke("ReinicioSalto", 0.2f);
        }
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            if (EnSuelo())
            {
                Cuerpo.velocity = new Vector2(MovimientosJugador * VelocidadMovimiento, ValorSalto);
                ValorSalto = 0.0f;
            }

            PuedeSaltar = true;
        }
    }

    private void ReinicioSalto()
    {
        PuedeSaltar = false;
        ValorSalto = 0;
    }

    private bool EnSuelo()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(Colision.bounds.center, Colision.bounds.size, 0, Vector2.down, 0.1f, SuperficieLayer);
        return raycastHit.collider != null;
    }
}
