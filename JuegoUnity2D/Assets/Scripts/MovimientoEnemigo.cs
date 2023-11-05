using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad = 5.0f;  // Velocidad de movimiento del enemigo

    void Start()
    {
        // Al inicio, invierte la escala en el eje X para que el enemigo mire hacia la izquierda.
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    void Update()
    {
        // Mueve el objeto hacia la izquierda a la velocidad especificada por segundo.
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
