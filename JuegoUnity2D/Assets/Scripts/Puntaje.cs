using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje; // Asigna el objeto TextMeshPro en el Inspector
    private int puntaje = 0;
    private float tiempoTranscurrido = 0f;
    public float velocidadAumentoPuntaje = 10.0f; // Velocidad de aumento del puntaje por segundo
    public float tiempoParaAumento = 1.0f; // Tiempo necesario para un aumento de puntaje

    private void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoParaAumento)
        {
            AumentarPuntaje();
            tiempoTranscurrido = 0f;
        }

        ActualizarPuntaje();
    }

    private void AumentarPuntaje()
    {
        puntaje += 1; // Incrementa el puntaje en 1 por cada aumento de puntaje
    }

    private void ActualizarPuntaje()
    {
        textoPuntaje.text = "SCORE: " + puntaje.ToString(); // Agrega "Score: " al texto
    }
}
