using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlerNivelDos : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float fuerzaSalto = 8.0f;
    public float velocidadCaidaRapida = 10.0f;

    private bool enElAire = false;
    private bool saltoAdicionalDisponible = true;

    public AudioClip sonidoSalto;
    public AudioClip sonidoColision;
    public AudioClip sonidoSaltoAire;
    public AudioClip cuartoSonido;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        MoverJugador();
        ManejarSalto();
        ManejarCaerRapidamente();
        ManejarSonido();
    }

    void MoverJugador()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * velocidadMovimiento * Time.deltaTime);
    }

    void ManejarSalto()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!enElAire)
            {
                Saltar();
                ReproducirSonido(sonidoSalto);
            }
            else if (saltoAdicionalDisponible)
            {
                Saltar();
                ReproducirSonido(sonidoSaltoAire);
                saltoAdicionalDisponible = false;
            }
        }
    }

    void ManejarCaerRapidamente()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && enElAire)
        {
            CaerRapidamente();
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

    void ManejarSonido()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReproducirSonido(cuartoSonido);
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
            ReproducirSonido(sonidoColision);
        }
    }

    void CambiarEscena()
    {
        string nombreDeEscena = "GameOver 2";
        SceneManager.LoadScene(nombreDeEscena);
    }

    void ReproducirSonido(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
