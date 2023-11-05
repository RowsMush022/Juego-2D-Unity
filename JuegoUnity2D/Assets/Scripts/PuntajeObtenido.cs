using UnityEngine;
using TMPro;

public class PuntajeObtenido : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje; // Objeto TextMeshPro donde se mostrará el puntaje (asignado en el Inspector)

    private void Start()
    {
        if (PlayerPrefs.HasKey("Puntaje"))
        {
            // Comprueba si hay un puntaje almacenado en PlayerPrefs
            int puntaje = PlayerPrefs.GetInt("Puntaje"); // Obtiene el puntaje almacenado
            textoPuntaje.text = "" + puntaje.ToString(); // Muestra el puntaje en el objeto TextMeshPro
        }
        else
        {
            textoPuntaje.text = " 0 pts"; // Si no hay un puntaje almacenado, muestra "0 pts"
        }
    }
}
