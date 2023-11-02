using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena que deseas cargar
    public AudioSource sonidoClick; // Arrastra el objeto AudioSource al Inspector

    void Start()
    {
        Button boton = GetComponent<Button>();
        boton.onClick.AddListener(ReproducirSonidoYCambiarEscena);
    }

    void ReproducirSonidoYCambiarEscena()
    {
        if (sonidoClick != null)
        {
            sonidoClick.Play(); // Reproduce el sonido al hacer clic
        }

        SceneManager.LoadScene(nombreDeEscena);
    }
}
