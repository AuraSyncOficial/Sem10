using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public float time = 3f;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el tag "enemy" ha entrado en el trigger
        if (other.CompareTag("enemy"))
        {
            // Destruye el objeto con el tag "enemy" después de 3 segundos
            Destroy(other.gameObject, time);
        }
    }
}