using UnityEngine;

public class MovimientoAvesPequeñas : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento de las aves pequeñas

    void Start()
    {
        // Refleja el sprite horizontalmente al inicio para que mire hacia la izquierda.
        FlipSprite();
    }

    void Update()
    {
        // Mueve el objeto hacia la izquierda a la velocidad especificada por segundo.
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }

    void FlipSprite()
    {
        // Voltea el sprite horizontalmente invirtiendo la escala en el eje X.
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
