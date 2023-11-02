using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxEffect : MonoBehaviour
{
    public float parallaxSpeed = 1.0f;

    private Material material;

    void Start()
    {
        // Obtener el material de la imagen
        material = GetComponent<Image>().material;
    }

    void Update()
    {
        // Obtener la posición actual del mouse
        Vector2 mousePosition = Input.mousePosition;

        // Calcular el offset X y Y para el material
        float offsetX = mousePosition.x / Screen.width * parallaxSpeed;
        float offsetY = mousePosition.y / Screen.height * parallaxSpeed;

        // Asignar el offset al material
        material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
