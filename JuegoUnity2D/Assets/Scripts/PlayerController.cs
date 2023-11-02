using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float fuerzaSalto = 8.0f;
    public float velocidadCaidaRapida = 10.0f;

    private bool enElAire = false;
    private bool saltoAdicionalDisponible = true;

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
            }
            else if (saltoAdicionalDisponible)
            {
                Saltar();
                saltoAdicionalDisponible = false;
            }
        }

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
        }
    }

    void CambiarEscena()
    {
        
        string nombreDeEscena = "GameOver"; 

        
        SceneManager.LoadScene(nombreDeEscena);
    }
}
