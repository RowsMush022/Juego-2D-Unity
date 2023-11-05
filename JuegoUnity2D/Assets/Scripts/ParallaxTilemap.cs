using UnityEngine;

public class ParallaxTilemap : MonoBehaviour
{
    public float parallaxSpeed = 1.0f;  // Ajusta la velocidad de desplazamiento hacia la izquierda.

    private Vector3 initialTilemapPosition;  // Almacena la posición inicial del Tilemap.

    private void Start()
    {
        // Guarda la posición inicial del Tilemap al iniciar.
        initialTilemapPosition = transform.position;
    }

    private void Update()
    {
        // Calcula el desplazamiento horizontal basado en la velocidad constante.
        float deltaPositionX = Time.deltaTime * parallaxSpeed;

        // Aplica el efecto de parallax solo en el eje X modificando la posición del Tilemap.
        transform.Translate(new Vector3(-deltaPositionX, 0, 0));

        // Revierte la posición del Tilemap a su posición inicial cuando se desplaza completamente fuera de la vista.
        if (transform.position.x <= initialTilemapPosition.x - transform.localScale.x)
        {
            transform.position = initialTilemapPosition;
        }
    }
}
