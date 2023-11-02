using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena que deseas cargar
    public AudioClip sonidoClick; // Asigna el archivo de sonido al Inspector

    private AudioSource audioSource; // AudioSource para reproducir el sonido

    void Start()
    {
        Button boton = GetComponent<Button>();
        boton.onClick.AddListener(CargarEscena);
        audioSource = gameObject.AddComponent<AudioSource>(); // Agregar un AudioSource al objeto
    }

    void CargarEscena()
    {
        if (sonidoClick != null)
        {
            audioSource.PlayOneShot(sonidoClick); // Reproduce el sonido al hacer clic
        }

        SceneManager.LoadScene(nombreDeEscena);
    }
}
