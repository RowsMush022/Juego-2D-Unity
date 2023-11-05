using UnityEngine;
using System.Collections;

public class GeneradorDePrefab : MonoBehaviour
{
    public GameObject prefabAGenerar; // El prefab que se generará
    public Transform posicionGeneracion; // La posición donde se generará el prefab
    public float tiempoMinimo = 1.0f; // El tiempo mínimo para la generación de prefabs
    public float tiempoMaximo = 3.0f; // El tiempo máximo para la generación de prefabs
    public float intervaloInvokeRepeating = 5.0f; // El intervalo para InvokeRepeating

    void Start()
    {
        // Usar InvokeRepeating para generar prefabs cada 'intervaloInvokeRepeating' segundos.
        InvokeRepeating("GenerarPrefabConInvokeRepeating", 0f, intervaloInvokeRepeating);

        // Usar una Coroutine para generar prefabs con intervalos aleatorios.
        StartCoroutine(GenerarPrefabPeriodicamente());
    }

    void GenerarPrefabConInvokeRepeating()
    {
        // Generar un prefab en la posición de generación.
        Instantiate(prefabAGenerar, posicionGeneracion.position, Quaternion.identity);
    }

    IEnumerator GenerarPrefabPeriodicamente()
    {
        while (true)
        {
            // Generar un tiempo de espera aleatorio dentro del rango definido.
            float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);

            // Esperar el tiempo definido antes de generar el prefab.
            yield return new WaitForSeconds(tiempoEspera);

            // Generar un prefab utilizando Invoke para un único evento en un tiempo aleatorio.
            Invoke("GenerarPrefabConInvoke", 0f);
        }
    }

    void GenerarPrefabConInvoke()
    {
        // Generar un prefab en la posición de generación.
        Instantiate(prefabAGenerar, posicionGeneracion.position, Quaternion.identity);
    }
}
