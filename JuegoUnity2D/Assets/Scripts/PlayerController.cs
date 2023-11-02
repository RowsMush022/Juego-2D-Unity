using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float fuerzaSalto = 8.0f;
    public float velocidadCaidaRapida = 10.0f;

    private bool enElAire = false;
    private bool saltoAdicionalDisponible = true;

    public AudioClip sonidoSalto; // Asigna el archivo de sonido de salto en el Inspector
    public AudioClip sonidoColision; // Asigna el archivo de sonido de colisión en el Inspector
    public AudioClip sonidoSaltoAire; // Asigna el archivo de sonido de salto en el aire en el Inspector
    public AudioClip cuartoSonido; // Agrega un nuevo sonido y asígnalo en el Inspector

    private AudioSource audioSource; // Referencia al componente AudioSource

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Obtén el componente AudioSource del mismo objeto
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!enElAire)
            {
                Saltar();
                ReproducirSonido(sonidoSalto); // Reproduce el sonido de salto
            }
            else if (saltoAdicionalDisponible)
            {
                Saltar();
                ReproducirSonido(sonidoSaltoAire); // Reproduce el nuevo sonido de salto en el aire
                saltoAdicionalDisponible = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && enElAire)
        {
            CaerRapidamente();
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReproducirSonido(cuartoSonido); // Reproduce el cuarto sonido cuando presionas la barra espaciadora
        }
    }

    void Saltar()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            enElAire = true;
        }
    }

    void CaerRapidamente()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb)
        {
            rb.velocity = new Vector2(rb.velocity.x, -velocidadCaidaRapida);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enElAire = false;
            saltoAdicionalDisponible = true;
        }

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            CambiarEscena();
            ReproducirSonido(sonidoColision); // Reproduce el sonido de colisión con un enemigo
        }
    }

    void CambiarEscena()
    {
        string nombreDeEscena = "GameOver";
        SceneManager.LoadScene(nombreDeEscena);
    }

    void ReproducirSonido(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip); // Reproduce el sonido especificado
        }
    }
}
