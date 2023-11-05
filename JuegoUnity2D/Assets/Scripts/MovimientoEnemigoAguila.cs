using UnityEngine;

public class MovimientoEnemigoAguila : MonoBehaviour
{
    public float velocidad = 5.0f;  // Velocidad de movimiento del enemigo águila

    void Start()
    {
        // Este método Start está vacío y no realiza ninguna acción al inicio.
        // Puede utilizarse para configuraciones iniciales, pero en este caso, no se utiliza.
    }

    void Update()
    {
        // Mueve el objeto hacia la izquierda a la velocidad especificada por segundo.
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
