using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje; // Objeto TextMeshPro donde se mostrará el puntaje (asignado en el Inspector)
    private int puntaje = 0; // Puntaje actual
    private float tiempoTranscurrido = 0f; // Tiempo transcurrido desde el último aumento de puntaje
    public float velocidadAumentoPuntaje = 10.0f; // Velocidad de aumento del puntaje por segundo
    public float tiempoParaAumento = 1.0f; // Tiempo necesario para un aumento de puntaje

    private void Update()
    {
        tiempoTranscurrido += Time.deltaTime; // Incrementa el tiempo transcurrido en cada fotograma

        if (tiempoTranscurrido >= tiempoParaAumento)
        {
            AumentarPuntaje(); // Llama a la función para aumentar el puntaje
            tiempoTranscurrido = 0f; // Reinicia el tiempo transcurrido
        }

        ActualizarPuntaje(); // Llama a la función para actualizar y mostrar el puntaje

        if (puntaje >= 500)
        {
            CambiarEscena(); // Si el puntaje llega a 500 o más, cambia a otra escena
        }
    }

    private void AumentarPuntaje()
    {
        puntaje += 1; // Incrementa el puntaje en 1 unidad por cada aumento de puntaje
    }

    private void ActualizarPuntaje()
    {
        textoPuntaje.text = "" + puntaje.ToString(); // Muestra el puntaje en el objeto TextMeshPro
        PlayerPrefs.SetInt("Puntaje", puntaje); // Almacena el puntaje en PlayerPrefs para futuras referencias
    }

    private void CambiarEscena()
    {
        string nombreDeEscena = "Ganaste"; // Nombre de la escena a la que se cambiará (puedes cambiarlo)
        SceneManager.LoadScene(nombreDeEscena); // Cambia a la escena especificada
    }
}
