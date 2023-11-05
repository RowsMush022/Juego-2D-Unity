using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public string nombreDeEscena; // El nombre de la escena que quieres cargar
    public AudioClip sonidoClick; // Asigna el archivo de sonido en el Inspector

    private AudioSource audioSource; // AudioSource para reproducir el sonido

    void Start()
    {
        // Obtener una referencia al componente Button adjunto a este objeto
        Button boton = GetComponent<Button>();

        // Agregar un evento para escuchar cuando se hace clic en el botón y llamar al método CargarEscena
        boton.onClick.AddListener(CargarEscena);

        // Agregar un componente AudioSource al objeto para reproducir sonidos
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void CargarEscena()
    {
        // Comprobar si se ha asignado un sonido para cuando se hace clic
        if (sonidoClick != null)
        {
            // Reproducir el sonido cuando se hace clic en el botón
            audioSource.PlayOneShot(sonidoClick);
        }

        // Cargar la escena especificada en la variable nombreDeEscena
        SceneManager.LoadScene(nombreDeEscena);
    }
}
