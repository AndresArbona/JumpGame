using UnityEngine;

public class Controlador_Camara : MonoBehaviour
{
    //player camera
    [SerializeField] private Transform Jugador;
    [SerializeField] private float DistanciaVision;
    [SerializeField] private float VelocidadCamara;
    private float MirandoHacia;

    private void Update()
    {
        //player camera
        transform.position = new Vector3(Jugador.position.x + MirandoHacia, transform.position.y, transform.position.z);
        MirandoHacia = Mathf.Lerp(MirandoHacia, (DistanciaVision * Jugador.localScale.x), Time.deltaTime * VelocidadCamara);
    }
}
