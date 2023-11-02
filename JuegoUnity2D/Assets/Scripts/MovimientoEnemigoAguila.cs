using UnityEngine;

public class MovimientoEnemigoAguila : MonoBehaviour
{
    public float velocidad = 5.0f;  

    void Start()
    {
        
    }

    void Update()
    {
        
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}














