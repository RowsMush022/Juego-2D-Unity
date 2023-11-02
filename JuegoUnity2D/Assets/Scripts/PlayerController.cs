using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float fuerzaSalto = 8.0f;

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
            Saltar();
        }
    }

    void Saltar()
    {
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
        }
    }
}
