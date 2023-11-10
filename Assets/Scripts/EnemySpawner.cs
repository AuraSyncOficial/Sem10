using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    private bool isSpawning = false;

    private void Awake()
    {
        Instance = this;
    }

    public void StartSpawn(int waveNumber)
    {
        isSpawning = true;
        StartCoroutine(SpawnEnemies(waveNumber));
    }

    public void StopSpawn()
    {
        isSpawning = false;
        StopAllCoroutines();
    }

    IEnumerator SpawnEnemies(int waveNumber)
    {
        int enemiesToSpawn = waveNumber * 2; // Ajusta según tus necesidades

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            // Puedes configurar propiedades adicionales del enemigo aquí

            yield return new WaitForSeconds(spawnInterval);
        }

        StopSpawn();
    }
}
