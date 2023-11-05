using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    public AudioSource audioSource; // Objeto AudioSource para reproducir música, debe ser asignado en el Inspector

    void Start()
    {
        // Verifica si se ha asignado un objeto AudioSource en el Inspector.
        if (audioSource != null)
        {
            // Reproduce la música del AudioSource al inicio del juego.
            audioSource.Play();
        }
    }
}
