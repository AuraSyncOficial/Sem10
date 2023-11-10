using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objetosASpawnear;  // Array de objetos que puedes asignar en el Inspector
    public Transform puntoSpawn;  // Punto donde se spawnearán los objetos
    public float tiempoDeEspera = 2f;  // Tiempo en segundos entre cada spawn

    void Start()
    {
        // Llama a la función SpawnObject repetidamente cada "tiempoDeEspera" segundos
        InvokeRepeating("SpawnObject", 0f, tiempoDeEspera);
    }

    void SpawnObject()
    {
        // Selecciona un objeto aleatorio del array
        GameObject objetoSeleccionado = objetosASpawnear[Random.Range(0, objetosASpawnear.Length)];

        // Instancia el objeto en el punto de spawn
        Instantiate(objetoSeleccionado, puntoSpawn.position, puntoSpawn.rotation);
    }
}
