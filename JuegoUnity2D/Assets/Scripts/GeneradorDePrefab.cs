using UnityEngine;
using System.Collections;

public class GeneradorDePrefab : MonoBehaviour
{
    public GameObject prefabAGenerar;
    public Transform posicionGeneracion;
    public float tiempoMinimo = 1.0f;
    public float tiempoMaximo = 3.0f;

    void Start()
    {
        
        StartCoroutine(GenerarPrefabPeriodicamente());
    }

    IEnumerator GenerarPrefabPeriodicamente()
    {
        while (true)
        {
            
            float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);

            
            yield return new WaitForSeconds(tiempoEspera);

            
            Instantiate(prefabAGenerar, posicionGeneracion.position, Quaternion.identity);
        }
    }
}
