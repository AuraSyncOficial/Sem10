using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    public Action OnWaveStart;
    public Action OnWaveEnd;

    private int currentWave = 0;
    private bool isWaveActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartWave();
        }
    }

    public void StartWave()
    {
        if (!isWaveActive)
        {
            currentWave++;
            Debug.Log("Comienza la oleada " + currentWave);

            EnemySpawner.Instance.StartSpawn(currentWave);

            isWaveActive = true;
            OnWaveStart?.Invoke();
        }
    }

    public void EndWave()
    {
        if (isWaveActive)
        {
            Debug.Log("Finaliza la oleada " + currentWave);

            EnemySpawner.Instance.StopSpawn();

            isWaveActive = false;
            OnWaveEnd?.Invoke();
        }
    }
}