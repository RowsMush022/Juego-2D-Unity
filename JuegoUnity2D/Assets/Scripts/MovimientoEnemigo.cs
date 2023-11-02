using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad = 5.0f;  
    
    void Start()
    {
        
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    void Update()
    {
        
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
