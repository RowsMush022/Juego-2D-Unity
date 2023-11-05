using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonControles : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena que deseas cargar
    public AudioClip sonidoClick; // Asigna el archivo de sonido al Inspector

    private AudioSource audioSource; // AudioSource para reproducir el sonido

    void Start()
    {
        // Obtener una referencia al componente Button adjunto a este objeto
        Button boton = GetComponent<Button>();

        // Agregar un evento que escuche el clic en el botón y llame al método CargarEscena
        boton.onClick.AddListener(CargarEscena);

        // Agregar un componente AudioSource al objeto para reproducir sonidos
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void CargarEscena()
    {
        // Comprueba si se ha asignado un sonido al hacer clic
        if (sonidoClick != null)
        {
            // Reproduce el sonido al hacer clic en el botón
            audioSource.PlayOneShot(sonidoClick);
        }

        // Carga la escena especificada en la variable nombreDeEscena
        SceneManager.LoadScene(nombreDeEscena);
    }
}
