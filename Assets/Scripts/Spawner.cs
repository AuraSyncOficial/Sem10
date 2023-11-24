using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objetosASpawnear;
    public Transform puntoSpawn;
    public float tiempoDeEspera = 2f;

    void Start()
    {

        InvokeRepeating("SpawnObject", 0f, tiempoDeEspera);
    }

    void SpawnObject()
    {

        GameObject objetoSeleccionado = objetosASpawnear[Random.Range(0, objetosASpawnear.Length)];


        Instantiate(objetoSeleccionado, puntoSpawn.position, puntoSpawn.rotation);
    }
}
