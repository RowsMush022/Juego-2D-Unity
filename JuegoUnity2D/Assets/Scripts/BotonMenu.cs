using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena que deseas cargar

    void Start()
    {
        Button boton = GetComponent<Button>();
        boton.onClick.AddListener(CargarEscena);
    }

    void CargarEscena()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
