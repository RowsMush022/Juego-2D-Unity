using UnityEngine;
using System.Collections;

public class GeneradorDePrefab : MonoBehaviour
{
    public GameObject prefabAGenerar;
    public Transform posicionGeneracion;
    public float tiempoMinimo = 1.0f;
    public float tiempoMaximo = 3.0f;
    public float intervaloInvokeRepeating = 5.0f;

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
            float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);

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
