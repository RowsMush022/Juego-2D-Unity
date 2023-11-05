using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxEffect : MonoBehaviour
{
    public float parallaxSpeed = 1.0f;  // Velocidad de efecto de paralaje

    private Material material;  // Referencia al material de la imagen

    void Start()
    {
        // Obtener el material de la imagen en el objeto con el componente Image.
        material = GetComponent<Image>().material;
    }

    void Update()
    {
        // Obtener la posición actual del mouse en la pantalla
        Vector2 mousePosition = Input.mousePosition;

        // Calcular el offset X y Y para el material en función de la posición del mouse
        float offsetX = mousePosition.x / Screen.width * parallaxSpeed;
        float offsetY = mousePosition.y / Screen.height * parallaxSpeed;

        // Asignar el offset calculado al material para crear el efecto de paralaje.
        material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
