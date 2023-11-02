using UnityEngine;
using TMPro;

public class PuntajeObtenido : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Puntaje"))
        {
            int puntaje = PlayerPrefs.GetInt("Puntaje");
            textoPuntaje.text = "" + puntaje.ToString();
        }
        else
        {
            textoPuntaje.text = " 0 pts";
        }
    }
}
