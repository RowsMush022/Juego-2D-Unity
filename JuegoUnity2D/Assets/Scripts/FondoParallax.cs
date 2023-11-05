using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoParallax : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento; // La velocidad a la que el fondo se mueve
    private Vector2 offset; // El desplazamiento del fondo
    private Material material; // El material del objeto con el fondo

    private void Awake()
    {
        // Obtener el material del componente SpriteRenderer adjunto a este objeto
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        // Calcula el desplazamiento basado en la velocidad y el tiempo
        offset = velocidadMovimiento * Time.deltaTime;

        // Aplica el desplazamiento al fondo
        material.mainTextureOffset += offset;
    }
}
