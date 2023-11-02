using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    public AudioSource audioSource; // Arrastra el objeto AudioSource al Inspector

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
