using UnityEngine;

public class MovimientoAvesPequeñas : MonoBehaviour
{
    public float velocidad = 5.0f;  

    void Start()
    {
        // Refleja el sprite horizontalmente al inicio para que mire hacia la izquierda.
        FlipSprite();
    }

    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }

    void FlipSprite()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
